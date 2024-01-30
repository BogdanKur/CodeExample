using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chestplates : MonoBehaviour
{
    public GameObject txt12;

    public GameObject txt22;

    public static int isChose2004 = 0, isChose2504 = 0, isChose2904 = 0, isChose3404 = 0;
    public int B2001 = 0, B2501 = 0, B2901 = 0, B3401 = 0;
    public static int sellects200 = 0, sellects250 = 0, sellects290 = 0, sellects340 = 0;
    public static int is2005 = 0, is2505 = 0, is2905 = 0, is3405 = 0;
    public int s1 = 0, s2 = 0, s3 = 0, s4 = 0;
    public static int p5200 = 1, p5250 = 1, p5290 = 1, p5340 = 1;
    public  GameObject but1lvl;
    public  GameObject but2lvl;
    public  GameObject but3lvl;
    public  GameObject but4lvl;

    public  GameObject buy1lvl;
    public  GameObject buy2lvl;
    public  GameObject buy3lvl;
    public  GameObject buy4lvl;
    public  GameObject select1lvl;
    public  GameObject select2lvl;
    public  GameObject select3lvl;
    public  GameObject select4lvl;
    public static int isCoins700 = 0, isCoins2000 = 0, isCoins5000 = 0, isCoins9999 = 0;

    public static int buyChestPlFor200DeFs98 = 0, buyChestPlFor250DeFs98 = 0, buyChestPlFor290DeFs98 = 0, buyChestPlFor340DeFs98 = 0;

    public static int isbuyChestPlFor200DeF = 0, isbuyChestPlFor250DeF = 0, isbuyChestPlFor290DeF = 0, isbuyChestPlFor340DeF = 0;

    public static int BB200def991 = 0, BB250def991 = 0, BB290def991 = 0, BB340def991 = 0;

    private void Start() 
    {
        isChose2004 = PlayerPrefs.GetInt("isChose2004", 0);
        isChose2504 = PlayerPrefs.GetInt("isChose2504", 0);
        isChose2904 = PlayerPrefs.GetInt("isChose2904", 0);
        isChose3404 = PlayerPrefs.GetInt("isChose3404", 0);

        p5200 = PlayerPrefs.GetInt("p5200", 1);
        p5250 = PlayerPrefs.GetInt("p5250", 1);
        p5290 = PlayerPrefs.GetInt("p5290", 1);
        p5340 = PlayerPrefs.GetInt("p5340", 1);

        is2005 = PlayerPrefs.GetInt("is2005", 0);
        is2505 = PlayerPrefs.GetInt("is2505", 0);
        is2905 = PlayerPrefs.GetInt("is2905", 0);
        is3405 = PlayerPrefs.GetInt("is3405", 0);

        BB200def991 = PlayerPrefs.GetInt("BB200def991", buyChestPlFor200DeFs98);
        BB250def991 = PlayerPrefs.GetInt("BB250def991", buyChestPlFor250DeFs98);
        BB290def991 = PlayerPrefs.GetInt("BB290def991", buyChestPlFor290DeFs98);
        BB340def991 = PlayerPrefs.GetInt("BB340def991", buyChestPlFor340DeFs98);

        buyChestPlFor200DeFs98 = PlayerPrefs.GetInt("buyChestPlFor200DeFs98", 0);
        buyChestPlFor250DeFs98 = PlayerPrefs.GetInt("buyChestPlFor250DeFs98", 0);
        buyChestPlFor290DeFs98 = PlayerPrefs.GetInt("buyChestPlFor290DeFs98", 0);
        buyChestPlFor340DeFs98 = PlayerPrefs.GetInt("buyChestPlFor340DeFs98", 0);
    }

    public void Buys700()
    {
        if(ChangeClicks.CocoTins >= 700)
        {
            isCoins700 = 1;

            if(isCoins700 == 1 && buyChestPlFor200DeFs98 == 0)
            {
                p5200 = 2;
                PlayerPrefs.SetInt("p5200", p5200);
                isbuyChestPlFor200DeF = 1;
                buyChestPlFor200DeFs98 = 1;
                PlayerPrefs.SetInt("buyChestPlFor200DeFs98", buyChestPlFor200DeFs98);
            }
        }
    }

    public void Buys2000()
    {
        if(ChangeClicks.CocoTins >= 2000)
        {
            isCoins2000 = 1;

            if(isCoins2000 == 1 && buyChestPlFor250DeFs98 == 0)
            {
                p5250 = 2;
                PlayerPrefs.SetInt("p5250", p5250);
                isbuyChestPlFor250DeF = 1;
                buyChestPlFor250DeFs98 = 1;
                PlayerPrefs.SetInt("buyChestPlFor250DeFs98", buyChestPlFor250DeFs98);
            }
        }
    }

    public void Buys5000()
    {
        if(ChangeClicks.CocoTins >= 5000)
        {
            isCoins5000 = 1;

            if(isCoins5000 == 1 && buyChestPlFor290DeFs98 == 0)
            {
                p5290 = 2;
                PlayerPrefs.SetInt("p5290", p5290);
                isbuyChestPlFor290DeF = 1;
                buyChestPlFor290DeFs98 = 1;
                PlayerPrefs.SetInt("buyChestPlFor290DeFs98", buyChestPlFor290DeFs98);
            }
        }
    }

    public void Buys9999()
    {
        if(ChangeClicks.CocoTins >= 9999)
        {
            isCoins9999 = 1;

            if(isCoins9999 == 1 && buyChestPlFor340DeFs98 == 0)
            {
                p5340 = 2;
                PlayerPrefs.SetInt("p5340", p5340);
                isbuyChestPlFor340DeF = 1;
                buyChestPlFor340DeFs98 = 1;
                PlayerPrefs.SetInt("buyChestPlFor340DeFs98", buyChestPlFor340DeFs98);
            }
        }
    }

    private void Update() 
    {
        if(ClickMouseCount.pCC2004 == 0 )
        {
            p5200 = 0;
        }

        if(ClickMouseCount.pCC2504 == 0 )
        {
            p5250 = 0;
        }

        if(ClickMouseCount.pCC2904 == 0 )
        {
            p5290 = 0;
        }

        if(ClickMouseCount.pCC3404 == 0 )
        {
            p5340 = 0;
        }

        B2001 = buyChestPlFor200DeFs98;
        B2501 = buyChestPlFor250DeFs98;
        B2901 = buyChestPlFor290DeFs98;
        B3401 = buyChestPlFor340DeFs98;

        if(buyChestPlFor200DeFs98 == 1)
        {
            BB200def991 = 2;
            PlayerPrefs.SetInt("BB200def991", BB200def991);
        }

        if(buyChestPlFor250DeFs98 == 1)
        {
            BB250def991 = 2;
            PlayerPrefs.SetInt("BB250def991", BB250def991);
        }

        if(buyChestPlFor290DeFs98 == 1)
        {
            BB290def991 = 2;
            PlayerPrefs.SetInt("BB290def991", BB290def991);
        }

        if(buyChestPlFor340DeFs98 == 1)
        {
            BB340def991 = 2;
            PlayerPrefs.SetInt("BB340def991", BB340def991);
        }

        if(p5200 == 0)
        {
            s1 = 1;
            buyChestPlFor200DeFs98 = 2;
            BB200def991 = buyChestPlFor200DeFs98;
            PlayerPrefs.SetInt("BB200def991", BB200def991);
        }

        if(p5250 == 0)
        {
            s2= 1;
            buyChestPlFor250DeFs98 = 2;
            BB250def991 = buyChestPlFor250DeFs98;
            PlayerPrefs.SetInt("BB250def991", BB250def991);
        }

        if(p5290 == 0)
        {
             s3= 1;
            buyChestPlFor290DeFs98 = 2;
            BB290def991 = buyChestPlFor290DeFs98;
            PlayerPrefs.SetInt("BB290def991", BB290def991);
        }

        if(p5340 == 0)
        {
            s4 = 1;
            buyChestPlFor340DeFs98 = 2; 
            BB340def991 = buyChestPlFor340DeFs98;
            PlayerPrefs.SetInt("BB340def991", BB340def991);
        }

        if(BB200def991 == 2)
        {
            txt12.SetActive(false);


            but1lvl.SetActive(false);

            buy1lvl.SetActive(true);
        }   

        if(BB250def991 == 2)
        {

            txt12.SetActive(false);

            but2lvl.SetActive(false);

            buy2lvl.SetActive(true);

        }

        if(BB290def991 == 2)
        {

            txt12.SetActive(false);

            but3lvl.SetActive(false);

            buy3lvl.SetActive(true);

        }

        if(BB340def991 == 2)
        {
            txt12.SetActive(false);

            buy4lvl.SetActive(true);

            but4lvl.SetActive(false);

        }

        if(is2005 == 1)
        {


            buy1lvl.SetActive(false);

            select1lvl.SetActive(true);

            but1lvl.SetActive(false);
        }

        if(is2505 == 1)
        {

            buy2lvl.SetActive(false);

            select2lvl.SetActive(true);

            but2lvl.SetActive(false);

        }

        if(is2905 == 1)
        {

            buy3lvl.SetActive(false);




            select3lvl.SetActive(true);

            but3lvl.SetActive(false);

        }

        if(is3405 == 1)
        {
            buy4lvl.SetActive(false);

            select4lvl.SetActive(true);

            but4lvl.SetActive(false);

        }

    }
    public void onT()
    {
        if(BB200def991 != 2 && BB250def991 != 2 && BB290def991 != 2 && BB340def991 != 2)
            txt12.SetActive(true);
    }

    public void OnText()
    {
        if(BB200def991 == 2 || BB250def991 == 2 ||BB290def991 == 2 || BB340def991 == 2)
            txt22.SetActive(true);
    }

    public void OffText()
    {
        txt22.SetActive(false);
    }

    public void isSelect200()
    {
        isChose2004 = 1;
        isChose2504 = 0;
        isChose2904 = 0;
        isChose3404 = 0;

        PlayerPrefs.SetInt("isChose2004", isChose2004);
        PlayerPrefs.SetInt("isChose2504", isChose2504);
        PlayerPrefs.SetInt("isChose2904", isChose2904);
        PlayerPrefs.SetInt("isChose3404", isChose3404);

        is2005 = 1;
        is2505 = 0;
        is2905 = 0;
        is3405 = 0;

        PlayerPrefs.SetInt("is2005", is2005);
        PlayerPrefs.SetInt("is2505", is2505);
        PlayerPrefs.SetInt("is2905", is2905);
        PlayerPrefs.SetInt("is3405", is3405);

        select1lvl.SetActive(true);
        select2lvl.SetActive(false);
        select3lvl.SetActive(false);
        select4lvl.SetActive(false);
        
        buy1lvl.SetActive(false);
    }

    public void isSelect250()
    {

        isChose2004 = 0;
        isChose2504 = 1;
        isChose2904 = 0;
        isChose3404 = 0;

        PlayerPrefs.SetInt("isChose2004", isChose2004);
        PlayerPrefs.SetInt("isChose2504", isChose2504);
        PlayerPrefs.SetInt("isChose2904", isChose2904);
        PlayerPrefs.SetInt("isChose3404", isChose3404);

        is2005 = 0;
        is2505 = 1;
        is2905 = 0;
        is3405 = 0;

        PlayerPrefs.SetInt("is2005", is2005);
        PlayerPrefs.SetInt("is2505", is2505);
        PlayerPrefs.SetInt("is2905", is2905);
        PlayerPrefs.SetInt("is3405", is3405);

        select1lvl.SetActive(false);
        select2lvl.SetActive(true);
        select3lvl.SetActive(false);
        select4lvl.SetActive(false);

        buy2lvl.SetActive(false);
    }

    public void isSelect290()
    {

        isChose2004 = 0;
        isChose2504 = 0;
        isChose2904 = 1;
        isChose3404 = 0;

        PlayerPrefs.SetInt("isChose2004", isChose2004);
        PlayerPrefs.SetInt("isChose2504", isChose2504);
        PlayerPrefs.SetInt("isChose2904", isChose2904);
        PlayerPrefs.SetInt("isChose3404", isChose3404);

        is2005 = 0;
        is2505 = 0;
        is2905 = 1;
        is3405 = 0;

        PlayerPrefs.SetInt("is2005", is2005);
        PlayerPrefs.SetInt("is2505", is2505);
        PlayerPrefs.SetInt("is2905", is2905);
        PlayerPrefs.SetInt("is3405", is3405);

        select1lvl.SetActive(false);
        select2lvl.SetActive(false);
        select3lvl.SetActive(true);
        select4lvl.SetActive(false);

        buy3lvl.SetActive(false);
    }

    public void isSelect340()
    {

        isChose2004 = 0;
        isChose2504 = 0;
        isChose2904 = 0;
        isChose3404 = 1;

        PlayerPrefs.SetInt("isChose2004", isChose2004);
        PlayerPrefs.SetInt("isChose2504", isChose2504);
        PlayerPrefs.SetInt("isChose2904", isChose2904);
        PlayerPrefs.SetInt("isChose3404", isChose3404);

        is2005 = 0;
        is2505 = 0;
        is2905 = 0;
        is3405 = 1;

        PlayerPrefs.SetInt("is2005", is2005);
        PlayerPrefs.SetInt("is2505", is2505);
        PlayerPrefs.SetInt("is2905", is2905);
        PlayerPrefs.SetInt("is3405", is3405);

        select1lvl.SetActive(false);
        select2lvl.SetActive(false);
        select3lvl.SetActive(false);
        select4lvl.SetActive(true);

        buy4lvl.SetActive(false);
    }
}
