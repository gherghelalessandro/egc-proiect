using System.Collections;
using System.Collections.Generic;
using System.Drawing;

using UnityEditor;

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Movement : MonoBehaviour
{

    public CharacterController characterController;
    
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public int jumps = 2;

    public Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    bool touched;
    public bool score = false;
    public bool jumps1 = true;
    bool nojump = false;
    public TextMeshProUGUI texts;
    int score1 = 0;


    public string text = "main hub";

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        if(jumps1==true)
        {
            texts.text = "Jumps:" + jumps;
        }
        if(score==true) {
            texts.text = "Score:" + score1;
        }
        
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);
        if(isGrounded && velocity.y<0&&touched&&nojump==false)
        {
            velocity.y=-2f;
            jumps = 2;
        }
        

        float x=Input.GetAxis("Horizontal");
        float z=Input.GetAxis("Vertical");

        Vector3 move=transform.right*x+transform.forward*z;

        characterController.Move(move*speed*Time.deltaTime);

        if(Input.GetButtonDown("Jump")&&jumps>0) 
        {
            velocity.y=Mathf.Sqrt(jumpHeight*gravity*-2f);
            jumps--;
            if(jumps1==true)
            {
                texts.text = "Jumps:" + jumps;
            }
            
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(transform.position.y<-20)
        {
            SceneManager.LoadScene(text);
        }
        velocity.y+=gravity*Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.tag == "platform"&&touched==false)
        {
            touched = true;
            nojump = true;
            jumps = 0;
            var mov = hit.gameObject.GetComponent<Omovement>();
            if (mov != null)
            {
                if (mov.active == false)
                {
                    mov.active = true;
                }
            }
            gameObject.transform.parent = hit.gameObject.transform;

        }
        else if(hit.collider.tag=="jumper")
        {
            
            var dos = hit.gameObject.GetComponent<do_something>();
            if(dos.active==true)
            {
                dos.do_some = true;
                if(dos.iscorect==true)
                {
                    score1++;
                }
                if(dos.iscorect==false&&dos.kill==true)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                dos.active = false;
            }
            
        }
        else if(hit.collider.tag=="changer"&&touched==false)
        {
            touched = true;
            gameObject.transform.parent = hit.gameObject.transform;
        }
        else if(hit.collider.tag=="nojump")
        {
            nojump = true; 
            jumps = 0;
            gameObject.transform.parent = null;
            touched= false;
        }
        else
        if(hit.collider.tag!="platform"&&hit.collider.tag !="changer")
        {
            touched=false;
            gameObject.transform.parent = null;
            nojump = false;
            jumps = 2;
        }
        
    }
}
