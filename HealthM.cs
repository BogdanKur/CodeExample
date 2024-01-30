using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using YG;

public class HealthM : MonoBehaviour
{
    public Button Adv;
    public GameObject Panel;
    public int CountHealth = 19;
    public int Count = 29, countt = 9;
    public float checkGroundOffsetY = -1.5f;
    public float checkGroundRadius = 3f;
    public GameObject Trigger;
    public int dmg;
    public TextMeshProUGUI TextClick2;
    public TextMeshProUGUI TextClick4;
    public TextMeshProUGUI TextClick6;

    private void OnTriggerStay2D(Collider2D other) 
    {
        countt += 1;
        Count += 1;
        if(ChangeClicks.Def994 > 0  && other.gameObject.name == "Enem(Clone)" && Count == 30)
        {
                ChangeClicks.Def994 -= Enemies.EnemDMG;
                CountHealth += 1;
        }

        if(other.gameObject.name == "Enem(Clone)" && ChangeClicks.Def994 <= 0 && countt == 10)
        {
            ChangeClicks.Def994 = 0;
            ChangeClicks.Health -= Enemies.EnemDMG;  
            if(ChangeClicks.Health <= 0)
            {
                Enemies.LL = 10;
                Enem1.LL = 10;
                Enem2.LL = 10;
                Enem3.LL = 10;
                Enem4.LL = 25;
                Enem5.LL = 35;
                Enem6.LL = 40;
                Enem7.LL = 45;
                Enem8.LL = 50;
                Enem9.LL = 50;




                PLayerMovee.CountOfEnemies = 0;
                //SceneManager.LoadScene(0);

                AdvBut();
            }
        }

        if(CountHealth >= 50)
            CountHealth = 0;

    }

    public void AdvBut()
    {
        Time.timeScale = 0;
        Panel.SetActive(true);
        Adv.interactable = true;
    }

    private void Update() 
    {
        if(Count >= 30)
        {
            Count = 0;
        }

        if(countt >= 10)
        {
            countt = 0;
        }

        TextClick2.text = ChangeClicks.Health.ToString();
        TextClick4.text = Enemies.Cm.ToString();
        TextClick6.text = ChangeClicks.Def994.ToString();
    }
}
