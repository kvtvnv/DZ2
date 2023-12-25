using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;//базова€ библиотека 
using UnityEngine.UI;
public class ForCube : MonoBehaviour
{
    public float Speed = 10f;
    public int a;
    public int b;
    public int c;
    public Text x;
    public GameObject sphere;
  
    // Start is called before the first frame update
    void Start()//часть кода, котора€ выполн€етс€ 1 раз при запуске сцены 
    {

    }

    // Update is called once per frame
    //void Update()//Ѕудет прорабатыватьс€ каждый раз, когда проигрываетс€ кадр 
    void FixedUpdate()//
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward*5 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward *5* Speed * Time.deltaTime);
        }
        if (c <= 0)
        {
            
            this.gameObject.SetActive(false);
            x.text = "»гра окончена";
        }
        else
        {
            x.text = c.ToString();
        }
    

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CEN");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        c--;
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("CET");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("CS");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TE");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TX");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("TS");
    }
     public void heal()
    {
        c = 6; 
    }
}
