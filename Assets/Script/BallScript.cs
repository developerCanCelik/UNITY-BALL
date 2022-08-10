using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BallScript : MonoBehaviour
{
    //top eğer deliklere değdiğinde scale değerini düşürerek yok olma effecti sağlayacağız.
    float dieSpeed = 0.03f;
    public GameObject canvas;
    public GameObject effect;
    private void Awake() {
        effect.SetActive(false);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "hole" ){
            Destroy(GetComponent<Rigidbody>());
            transform.position = other.gameObject.transform.position;
            InvokeRepeating("die",.0f,0.02f);
        }
        if(other.gameObject.name == "target"){
            effect.SetActive(true);
            Destroy(GetComponent<Rigidbody>());
            Invoke("canvasActive",1f);

        }
    }
    void die(){
        transform.localScale -= new Vector3(dieSpeed, dieSpeed, dieSpeed);
        if(transform.localScale.x <= .0f){
            SceneManager.LoadScene("Scene/Game");
        }
    }
    void canvasActive(){
        Time.timeScale = 0.0f;
        canvas.SetActive(true);
    }
}
