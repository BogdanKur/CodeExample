using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class PLayerMovee : MonoBehaviour
{
    public TextMeshProUGUI textFroz;
    public TextMeshProUGUI textFire;
    public TextMeshProUGUI textOtrava;

    public static int EFFectFroz = 0, EFFectFire = 0, EFFectOtrava = 0;
    public static int EFFectFroz1 = 0, EFFectFire1 = 0, EFFectOtrava1 = 0;
    public static int p = 0, p1 =0;
    public int PPPP = 0;
    public static int CountOfEnemies = 0;   
    public float mvInp = 0f, mvInp1 = 0f;
    public SpriteRenderer objectRenderer;
    public static float vlevo = 0;
    public static float vverx = 0;
    public static float vpravo = 0;
    public static float vniz = 0;
    public Joystick joystick;

    public GameObject gm1;
    public GameObject gm2;
    public GameObject gm3;
    public GameObject gm4;
    public GameObject gm5;
    public GameObject gm6;
    public GameObject gm7;

    public Animator animator;
    private float RunP = 0.0f;
    private float RunP1 = 0.0f;
    private float RunP2 = 0.0f;
    public float speed = 5.0f;
    public static float h, v;
    public Rigidbody2D rb;
    
    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
        objectRenderer = GetComponent<SpriteRenderer>();
    }


    public void Prz()
    {
        Material transparentMaterial = new Material(objectRenderer.material);
            transparentMaterial.color = new Color(objectRenderer.material.color.r, objectRenderer.material.color.g, objectRenderer.material.color.b, 0f);
        
        objectRenderer.material = transparentMaterial;
    }

    public void Prz1()
    {
        Material transparentMaterial = new Material(objectRenderer.material);
            transparentMaterial.color = new Color(objectRenderer.material.color.r, objectRenderer.material.color.g, objectRenderer.material.color.b, 1f);
        
        objectRenderer.material = transparentMaterial;
    }

    private void FixedUpdate() 
    {   
        
        if(EFFectFroz < 1250)
        {
            EFFectFroz += 1;

            if(EFFectFroz % 50 == 0)
                textFroz.text = (26-(EFFectFroz/50)).ToString();
        }

        if(EFFectFroz >= 1250 && EFFectFroz1 < 200)
            EFFectFroz1++;




        if(EFFectFire < 2000) 
        {
            EFFectFire += 1;

            if(EFFectFire % 50 == 0)
                textFire.text = (41-(EFFectFire/50)).ToString();
        }


        if(EFFectFire >= 2000 && EFFectFire1 < 150)
            EFFectFire1++;





        if(EFFectOtrava < 3000)
        {
            EFFectOtrava += 1;

            if(EFFectOtrava % 50 == 0)
                textOtrava.text = (61-(EFFectOtrava/50)).ToString();
        }
        
        if(EFFectOtrava >= 3000 && EFFectOtrava1 < 150)
            EFFectOtrava1++;




        if(EFFectFroz1 >= 200)
        {
            EFFectFroz = 0;
            EFFectFroz1 = 0;
        }

        if(EFFectFire1 == 150)
        {
            EFFectFire = 0;
            EFFectFire1 = 0;
        }

        if(EFFectOtrava1 == 150)
        {
            EFFectOtrava = 0;
            EFFectOtrava1 = 0;
        }


        PPPP = CountOfEnemies;
       // if(CountOfEnemies == 15)
       // {
         //   CountOfEnemies = 0;
        //}

        float moveinput = joystick.Horizontal;
        float moveinput1 = joystick.Vertical;


        float moveXJoys = Input.GetAxis("Horizontal");
        float moveYJoys = Input.GetAxis("Vertical");

        if(moveinput == 0 && moveinput1 == 0)
            rb.velocity = new Vector2(speed * moveXJoys, speed * moveYJoys);


        if(moveinput != 0 || moveinput1 != 0)
            rb.velocity = new Vector2(speed * moveinput, speed * moveinput1);

        

        
        

       if(moveinput1 >= 0.9 || moveinput1 <= -0.9 && moveYJoys == 0 && moveXJoys == 0)
            RunP = 1.0f;
        
        if(moveinput1 < 0.9 && moveinput1 > -0.9 && moveYJoys == 0 && moveXJoys == 0)
            RunP = 0.0f;



        if(moveinput <= -0.5 && moveYJoys == 0 && moveXJoys == 0)
            RunP1 = 1.0f;
        
        if(moveinput >= 0.2 && moveYJoys == 0 && moveXJoys == 0)
            RunP2 = 1.0f;

        if(moveinput < 0.5 && moveinput > -0.5 && moveYJoys == 0 && moveXJoys == 0)
        {
            RunP1 = 0.0f;
            RunP2 = 0.0f;
        }




        if(moveYJoys == 1 || moveYJoys == -1 && moveinput == 0 && moveinput1 == 0)
            RunP = 1.0f;
        
        if(moveYJoys == 0 && moveinput == 0 && moveinput1 == 0)
            RunP = 0.0f;



        if(moveXJoys == -1 && moveinput == 0 && moveinput1 == 0)
        {
            RunP1 = 1.0f;
            RunP2 = 0.0f;
        }
            
        
        if(moveXJoys == 1 && moveinput == 0 && moveinput1 == 0)
        {
            RunP2 = 1.0f;
            RunP1 = 0.0f;
        }
            

        if(moveXJoys == 0 && moveinput == 0 && moveinput1 == 0)
        {
            RunP1 = 0.0f;
            RunP2 = 0.0f;
        }

        mvInp = moveinput;
        mvInp1 = moveinput1;

    

        vverx = 0f;
        vniz = 0f;
        vpravo = 0f;
        vlevo = 0f;

        animator.SetFloat("RunP", Mathf.Abs(RunP));
        animator.SetFloat("RunP1", Mathf.Abs(RunP1));
        animator.SetFloat("RunP2", Mathf.Abs(RunP2));

        if(ClickMouseCount.Ch1 == 1)
        {
            gm1.SetActive(true);
            gm2.SetActive(false);
            gm3.SetActive(false);
            gm4.SetActive(false);
            gm5.SetActive(false);
            gm6.SetActive(false);
            gm7.SetActive(false);
        }

        if(ClickMouseCount.Ch2 == 1)
        {
            gm1.SetActive(false);
            gm2.SetActive(true);
            gm3.SetActive(false);
            gm4.SetActive(false);
            gm5.SetActive(false);
            gm6.SetActive(false);
            gm7.SetActive(false);
        }

        if(ClickMouseCount.Ch3 == 1)
        {
            gm1.SetActive(false);
            gm2.SetActive(false);
            gm3.SetActive(true);
            gm4.SetActive(false);
            gm5.SetActive(false);
            gm6.SetActive(false);
            gm7.SetActive(false);
        }

         if(ClickMouseCount.Ch4 == 1)
        {
            gm1.SetActive(false);
            gm2.SetActive(false);
            gm3.SetActive(false);
            gm4.SetActive(true);
            gm5.SetActive(false);
            gm6.SetActive(false);
            gm7.SetActive(false);
        }

        if(ClickMouseCount.Ch5 == 1)
        {
            gm1.SetActive(false);
            gm2.SetActive(false);
            gm3.SetActive(false);
            gm4.SetActive(false);
            gm5.SetActive(true);
            gm6.SetActive(false);
            gm7.SetActive(false);
        }

        if(ClickMouseCount.Ch6 == 1)
        {
            gm1.SetActive(false);
            gm2.SetActive(false);
            gm3.SetActive(false);
            gm4.SetActive(false);
            gm5.SetActive(false);
            gm6.SetActive(true);
            gm7.SetActive(false);
        }

        if(ClickMouseCount.Ch7 == 1)
        {
            gm1.SetActive(false);
            gm2.SetActive(false);
            gm3.SetActive(false);
            gm4.SetActive(false);
            gm5.SetActive(false);
            gm6.SetActive(false);
            gm7.SetActive(true);
        }
    }

}
