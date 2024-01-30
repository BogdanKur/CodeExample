using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwordScripts : MonoBehaviour
{
    public GameObject txt1;

    public GameObject txt2;


    public static int isChose1007 = 0, isChose4507 = 0, isChose19997 = 0, isChose36507 = 0, isChose55557 = 0, isChose75007 = 0, isChose99997 = 0;
    public int B2001 = 0, B2501 = 0, B2901 = 0, B3401 = 0;
    public static int sellects100 = 0, sellects450 = 0, sellects1999 = 0, sellects3650 = 0, sellects5555 = 0, sellects7500 = 0, sellects9999 = 0;
    public static int is1008 = 0, is4508 = 0, is19998 = 0, is36508 = 0, is55558 = 0, is75008 = 0, is99998 = 0;
    public int s1 = 0, s2 = 0, s3 = 0, s4 = 0;
    public static int p1008 = 1, p4508 = 1, p19998 = 1, p36508 = 1, p55558 = 1, p75008 = 1, p99998 = 1;
    public  GameObject but1lvl;
    public  GameObject but2lvl;
    public  GameObject but3lvl;
    public  GameObject but4lvl;
    public  GameObject but5lvl;
    public  GameObject but6lvl;
    public  GameObject but7lvl;

    public  GameObject buy1lvl;
    public  GameObject buy2lvl;
    public  GameObject buy3lvl;
    public  GameObject buy4lvl;
    public  GameObject buy5lvl;
    public  GameObject buy6lvl;
    public  GameObject buy7lvl;

    public  GameObject select1lvl;
    public  GameObject select2lvl;
    public  GameObject select3lvl;
    public  GameObject select4lvl;
    public  GameObject select5lvl;
    public  GameObject select6lvl;
    public  GameObject select7lvl;

    public static int isCoins700 = 0, isCoins2000 = 0, isCoins5000 = 0, isCoins99991 = 0 , isCoins99992 = 0, isCoins99993 = 0, isCoins99994 = 0;

    public static int buyChestPlFor100DeFs993 = 0, buyChestPlFor450DeFs993 = 0, buyChestPlFor1999DeFs993 = 0, buyChestPlFor3650DeFs993 = 0, buyChestPlFor5555DeFs993 = 0, buyChestPlFor7500DeFs993 = 0, buyChestPlFor9999DeFs993 = 0;

    public static int isbuyChestPlFor200DeF = 0, isbuyChestPlFor250DeF = 0, isbuyChestPlFor290DeF = 0, isbuyChestPlFor340DeF = 0;

    public static int BB100def995 = 0, BB450def995 = 0, BB1999def995 = 0, BB3650def995 = 0, BB5555def995 = 0, BB7500def995 = 0, BB9999def995 = 0;

    private void Start() 
    {
        isChose1007 = PlayerPrefs.GetInt("isChose1007", 0);
        isChose4507 = PlayerPrefs.GetInt("isChose4507", 0);
        isChose19997 = PlayerPrefs.GetInt("isChose19997", 0);
        isChose36507 = PlayerPrefs.GetInt("isChose36507", 0);
        isChose55557 = PlayerPrefs.GetInt("isChose55557", 0);
        isChose75007 = PlayerPrefs.GetInt("isChose75007", 0);
        isChose99997 = PlayerPrefs.GetInt("isChose99997", 0);

        p1008 = PlayerPrefs.GetInt("p1008", 1);
        p4508 = PlayerPrefs.GetInt("p4508", 1);
        p19998 = PlayerPrefs.GetInt("p19998", 1);
        p36508 = PlayerPrefs.GetInt("p36508", 1);
        p55558 = PlayerPrefs.GetInt("p55558", 1);
        p75008 = PlayerPrefs.GetInt("p75008", 1);
        p99998 = PlayerPrefs.GetInt("p99998", 1);

        is1008 = PlayerPrefs.GetInt("is1008", 0);
        is4508 = PlayerPrefs.GetInt("is4508", 0);
        is19998 = PlayerPrefs.GetInt("is19998", 0);
        is36508 = PlayerPrefs.GetInt("is36508", 0);
        is55558 = PlayerPrefs.GetInt("is55558", 0);
        is75008 = PlayerPrefs.GetInt("is75008", 0);
        is99998 = PlayerPrefs.GetInt("is99998", 0);

        BB100def995 = PlayerPrefs.GetInt("BB100def995", buyChestPlFor100DeFs993);
        BB450def995 = PlayerPrefs.GetInt("BB450def995", buyChestPlFor450DeFs993);
        BB1999def995 = PlayerPrefs.GetInt("BB1999def995", buyChestPlFor1999DeFs993);
        BB3650def995 = PlayerPrefs.GetInt("BB3650def995", buyChestPlFor3650DeFs993);
        BB5555def995 = PlayerPrefs.GetInt("BB5555def995", buyChestPlFor5555DeFs993);
        BB7500def995 = PlayerPrefs.GetInt("BB7500def995", buyChestPlFor7500DeFs993);
        BB9999def995 = PlayerPrefs.GetInt("BB9999def995", buyChestPlFor9999DeFs993);

        buyChestPlFor100DeFs993 = PlayerPrefs.GetInt("buyChestPlFor100DeFs993", 0);
        buyChestPlFor450DeFs993 = PlayerPrefs.GetInt("buyChestPlFor450DeFs993", 0);
        buyChestPlFor1999DeFs993 = PlayerPrefs.GetInt("buyChestPlFor1999DeFs993", 0);
        buyChestPlFor3650DeFs993 = PlayerPrefs.GetInt("buyChestPlFor3650DeFs993", 0);
        buyChestPlFor5555DeFs993 = PlayerPrefs.GetInt("buyChestPlFor5555DeFs993", 0);
        buyChestPlFor7500DeFs993 = PlayerPrefs.GetInt("buyChestPlFor7500DeFs993", 0);
        buyChestPlFor9999DeFs993 = PlayerPrefs.GetInt("buyChestPlFor9999DeFs993", 0);
    }

    public void Buys700()
    {
        if(ChangeClicks.CocoTins >= 100)
        {
            isCoins700 = 1;

            if(isCoins700 == 1 && buyChestPlFor100DeFs993 == 0)
            {
                p1008 = 2;
                PlayerPrefs.SetInt("p1008", p1008);
                isbuyChestPlFor200DeF = 1;
                buyChestPlFor100DeFs993 = 1;
                PlayerPrefs.SetInt("buyChestPlFor100DeFs993", buyChestPlFor100DeFs993);
            }
        }
    }

    public void Buys2000()
    {
        if(ChangeClicks.CocoTins >= 450)
        {
            isCoins2000 = 1;

            if(isCoins2000 == 1 && buyChestPlFor450DeFs993 == 0)
            {
                p4508 = 2;
                PlayerPrefs.SetInt("p4508", p4508);
                isbuyChestPlFor250DeF = 1;
                buyChestPlFor450DeFs993 = 1;
                PlayerPrefs.SetInt("buyChestPlFor450DeFs993", buyChestPlFor450DeFs993);
            }
        }
    }

    public void Buys5000()
    {
        if(ChangeClicks.CocoTins >= 1999)
        {
            isCoins5000 = 1;

            if(isCoins5000 == 1 && buyChestPlFor1999DeFs993 == 0)
            {
                p19998 = 2;
                PlayerPrefs.SetInt("p19998", p19998);
                isbuyChestPlFor290DeF = 1;
                buyChestPlFor1999DeFs993 = 1;
                PlayerPrefs.SetInt("buyChestPlFor1999DeFs993", buyChestPlFor1999DeFs993);
            }
        }
    }

    public void Buys9999()
    {
        if(ChangeClicks.CocoTins >= 3650)
        {
            isCoins99991 = 1;

            if(isCoins99991 == 1 && buyChestPlFor3650DeFs993 == 0)
            {
                p36508 = 2;
                PlayerPrefs.SetInt("p36508", p36508);
                isbuyChestPlFor340DeF = 1;
                buyChestPlFor3650DeFs993 = 1;
                PlayerPrefs.SetInt("buyChestPlFor3650DeFs993", buyChestPlFor3650DeFs993);
            }
        }
    }

    public void Buys5555()
    {
        if(ChangeClicks.CocoTins >= 5555)
        {
            isCoins99992 = 1;

            if(isCoins99992 == 1 && buyChestPlFor5555DeFs993 == 0)
            {
                p55558 = 2;
                PlayerPrefs.SetInt("p55558", p55558);
                isbuyChestPlFor340DeF = 1;
                buyChestPlFor5555DeFs993 = 1;
                PlayerPrefs.SetInt("buyChestPlFor5555DeFs993", buyChestPlFor5555DeFs993);
            }
        }
    }

    public void Buys7500()
    {
        if(ChangeClicks.CocoTins >= 7500)
        {
            isCoins99993 = 1;

            if(isCoins99993 == 1 && buyChestPlFor7500DeFs993 == 0)
            {
                p75008 = 2;
                PlayerPrefs.SetInt("p75008", p75008);
                isbuyChestPlFor340DeF = 1;
                buyChestPlFor7500DeFs993 = 1;
                PlayerPrefs.SetInt("buyChestPlFor7500DeFs993", buyChestPlFor7500DeFs993);
            }
        }
    }

    public void Buys9000()
    {
        if(ChangeClicks.CocoTins >= 9999)
        {
            isCoins99994 = 1;

            if(isCoins99994 == 1 && buyChestPlFor9999DeFs993 == 0)
            {
                p99998 = 2;
                PlayerPrefs.SetInt("p99998", p99998);
                isbuyChestPlFor340DeF = 1;
                buyChestPlFor9999DeFs993 = 1;
                PlayerPrefs.SetInt("buyChestPlFor9999DeFs993", buyChestPlFor9999DeFs993);
            }
        }
    }

    private void Update() 
    {
        if(ClickMouseCount.pCC10092 == 0 )
        {
            p1008 = 0;
        }

        if(ClickMouseCount.pCC45092 == 0 )
        {
            p4508 = 0;
        }

        if(ClickMouseCount.pCC199992 == 0 )
        {
            p19998 = 0;
        }

        if(ClickMouseCount.pCC365092 == 0 )
        {
            p36508 = 0;
        }

        if(ClickMouseCount.pCC555592 == 0 )
        {
            p55558 = 0;
        }

        if(ClickMouseCount.pCC750092 == 0 )
        {
            p75008 = 0;
        }

        if(ClickMouseCount.pCC999992 == 0 )
        {
            p99998 = 0;
        }

        if(buyChestPlFor100DeFs993 == 1)
        {
            BB100def995 = 2;
            PlayerPrefs.SetInt("BB100def995", BB100def995);
        }

        if(buyChestPlFor450DeFs993 == 1)
        {
            BB450def995 = 2;
            PlayerPrefs.SetInt("BB450def995", BB450def995);
        }

        if(buyChestPlFor1999DeFs993 == 1)
        {
            BB1999def995 = 2;
            PlayerPrefs.SetInt("BB1999def995", BB1999def995);
        }

        if(buyChestPlFor3650DeFs993 == 1)
        {
            BB3650def995 = 2;
            PlayerPrefs.SetInt("BB3650def995", BB3650def995);
        }

        if(buyChestPlFor5555DeFs993 == 1)
        {
            BB5555def995 = 2;
            PlayerPrefs.SetInt("BB5555def995", BB5555def995);
        }

        if(buyChestPlFor7500DeFs993 == 1)
        {
            BB7500def995 = 2;
            PlayerPrefs.SetInt("BB7500def995", BB7500def995);
        }

        if(buyChestPlFor9999DeFs993 == 1)
        {
            BB9999def995 = 2;
            PlayerPrefs.SetInt("BB9999def995", BB9999def995);
        }

        B2001 = buyChestPlFor100DeFs993;
        B2501 = buyChestPlFor450DeFs993;
        B2901 = buyChestPlFor1999DeFs993;
        B3401 = buyChestPlFor3650DeFs993;

        if(p1008 == 0)
        {
            s1 = 1;
            buyChestPlFor100DeFs993 = 2;
            BB100def995 = buyChestPlFor100DeFs993;
            PlayerPrefs.SetInt("BB100def995", BB100def995);
        }

        if(p4508 == 0)
        {
            s2= 1;
            buyChestPlFor450DeFs993 = 2;
            BB450def995 = buyChestPlFor450DeFs993;
            PlayerPrefs.SetInt("BB450def995", BB450def995);
        }

        if(p19998 == 0)
        {
             s3= 1;
            buyChestPlFor1999DeFs993 = 2;
            BB1999def995 = buyChestPlFor1999DeFs993;
            PlayerPrefs.SetInt("BB1999def995", BB1999def995);
        }

        if(p36508 == 0)
        {
            s4 = 1;
            buyChestPlFor3650DeFs993 = 2; 
            BB5555def995 = buyChestPlFor3650DeFs993;
            PlayerPrefs.SetInt("BB3650def995", BB3650def995);
        }

        if(p55558 == 0)
        {
            s4 = 1;
            buyChestPlFor5555DeFs993 = 2; 
            BB5555def995 = buyChestPlFor5555DeFs993;
            PlayerPrefs.SetInt("BB5555def995", BB5555def995);
        }

        if(p75008 == 0)
        {
            s4 = 1;
            buyChestPlFor7500DeFs993 = 2; 
            BB7500def995 = buyChestPlFor7500DeFs993;
            PlayerPrefs.SetInt("BB7500def995", BB7500def995);
        }

        if(p99998 == 0)
        {
            s4 = 1;
            buyChestPlFor9999DeFs993 = 2; 
            BB9999def995 = buyChestPlFor9999DeFs993;
            PlayerPrefs.SetInt("BB9999def995", BB9999def995);
        }

        if(BB100def995 == 2)
        {
            txt1.SetActive(false);


            but1lvl.SetActive(false);
           // but2lvl.SetActive(true);
           /// but3lvl.SetActive(true);
           // but4lvl.SetActive(true);
           // but5lvl.SetActive(true);
           // but6lvl.SetActive(true);
           // but7lvl.SetActive(true);

            buy1lvl.SetActive(true);
           // buy2lvl.SetActive(false);
           // buy3lvl.SetActive(false);
            //buy4lvl.SetActive(false);
           // buy5lvl.SetActive(false);
            //buy6lvl.SetActive(false);
            //buy7lvl.SetActive(false);

        }   

        if(BB450def995 == 2)
        {
            txt1.SetActive(false);


            but2lvl.SetActive(false);

            buy2lvl.SetActive(true);
        }

        if(BB1999def995 == 2)
        {
            txt1.SetActive(false);


            but3lvl.SetActive(false);

            buy3lvl.SetActive(true);

        }

        if(BB3650def995 == 2)
        {

            txt1.SetActive(false);



            buy4lvl.SetActive(true);

            but4lvl.SetActive(false);


        }

        if(BB5555def995 == 2)
        {
            txt1.SetActive(false);

            buy5lvl.SetActive(true);

            but5lvl.SetActive(false);



        }   

        if(BB7500def995 == 2)
        {
            txt1.SetActive(false);

            buy6lvl.SetActive(true);

            but6lvl.SetActive(false);


        }   

        if(BB9999def995 == 2)
        {
            txt1.SetActive(false);

            buy7lvl.SetActive(true);

            but7lvl.SetActive(false);


        }      


        if(is1008 == 1)
        {

            buy1lvl.SetActive(false);

            select1lvl.SetActive(true);

            but1lvl.SetActive(false);
        }

        if(is4508 == 1)
        {
            buy2lvl.SetActive(false);

            select2lvl.SetActive(true);


            but2lvl.SetActive(false);
        }

        if(is19998 == 1)
        {

            buy3lvl.SetActive(false);

            select3lvl.SetActive(true);

            but3lvl.SetActive(false);
        }

        if(is36508 == 1)
        {

            buy4lvl.SetActive(false);

            select4lvl.SetActive(true);

            but4lvl.SetActive(false);
        }

        if(is55558 == 1)
        {
            buy5lvl.SetActive(false);

            select5lvl.SetActive(true);

            but5lvl.SetActive(false);
        }

        if(is75008 == 1)
        {
            buy6lvl.SetActive(false);

            select6lvl.SetActive(true);

            but6lvl.SetActive(false);
        }

        if(is99998 == 1)
        {

            buy7lvl.SetActive(false);

            select7lvl.SetActive(true);

            but7lvl.SetActive(false);
        }
    }

    public void onT()
    {
        if(BB9999def995 != 2 &&  BB7500def995 != 2 && BB100def995 != 2 && BB5555def995 != 2 &&  BB3650def995 != 2 && BB1999def995 != 2 && BB450def995 != 2)
            txt1.SetActive(true);
    }

    public void OnText()
    {
        if(BB9999def995 == 2 ||  BB7500def995 == 2 || BB100def995 == 2 || BB5555def995 == 2 ||  BB3650def995 == 2 || BB1999def995 == 2 || BB450def995 == 2)
            txt2.SetActive(true);
    }

    public void OffText()
    {
        txt2.SetActive(false);
    }


    public void isSelect200()
    {
        isChose1007 = 1;
        isChose4507 = 0;
        isChose19997 = 0;
        isChose36507 = 0;
        isChose55557 = 0;
        isChose75007 = 0;
        isChose99997 = 0;

        PlayerPrefs.SetInt("isChose1007", isChose1007);
        PlayerPrefs.SetInt("isChose4507", isChose4507);
        PlayerPrefs.SetInt("isChose19997", isChose19997);
        PlayerPrefs.SetInt("isChose36507", isChose36507);
        PlayerPrefs.SetInt("isChose55557", isChose55557);
        PlayerPrefs.SetInt("isChose75007", isChose75007);
        PlayerPrefs.SetInt("isChose99997", isChose99997);

        is1008 = 1;
        is4508 = 0;
        is19998 = 0;
        is36508 = 0;
        is55558 = 0;
        is75008 = 0;
        is99998 = 0;

        PlayerPrefs.SetInt("is1008", is1008);
        PlayerPrefs.SetInt("is4508", is4508);
        PlayerPrefs.SetInt("is19998", is19998);
        PlayerPrefs.SetInt("is36508", is36508);
        PlayerPrefs.SetInt("is55558", is55558);
        PlayerPrefs.SetInt("is75008", is75008);
        PlayerPrefs.SetInt("is99998", is99998);

        select1lvl.SetActive(true);
        select2lvl.SetActive(false);
        select3lvl.SetActive(false);
        select4lvl.SetActive(false);
        select5lvl.SetActive(false);
        select6lvl.SetActive(false);
        select7lvl.SetActive(false);
        
        buy1lvl.SetActive(false);
    }

    public void isSelect250()
    {

        isChose1007 = 0;
        isChose4507 = 1;
        isChose19997 = 0;
        isChose36507 = 0;
        isChose55557 = 0;
        isChose75007 = 0;
        isChose99997 = 0;

        PlayerPrefs.SetInt("isChose1007", isChose1007);
        PlayerPrefs.SetInt("isChose4507", isChose4507);
        PlayerPrefs.SetInt("isChose19997", isChose19997);
        PlayerPrefs.SetInt("isChose36507", isChose36507);
        PlayerPrefs.SetInt("isChose55557", isChose55557);
        PlayerPrefs.SetInt("isChose75007", isChose75007);
        PlayerPrefs.SetInt("isChose99997", isChose99997);

        is1008 = 0;
        is4508 = 1;
        is19998 = 0;
        is36508 = 0;
        is55558 = 0;
        is75008 = 0;
        is99998 = 0;

        PlayerPrefs.SetInt("is1008", is1008);
        PlayerPrefs.SetInt("is4508", is4508);
        PlayerPrefs.SetInt("is19998", is19998);
        PlayerPrefs.SetInt("is36508", is36508);
        PlayerPrefs.SetInt("is55558", is55558);
        PlayerPrefs.SetInt("is75008", is75008);
        PlayerPrefs.SetInt("is99998", is99998);

        select1lvl.SetActive(false);
        select2lvl.SetActive(true);
        select3lvl.SetActive(false);
        select4lvl.SetActive(false);
        select5lvl.SetActive(false);
        select6lvl.SetActive(false);
        select7lvl.SetActive(false);
        
        buy2lvl.SetActive(false);
    }

    public void isSelect290()
    {

         isChose1007 = 0;
        isChose4507 = 0;
        isChose19997 = 1;
        isChose36507 = 0;
        isChose55557 = 0;
        isChose75007 = 0;
        isChose99997 = 0;

        PlayerPrefs.SetInt("isChose1007", isChose1007);
        PlayerPrefs.SetInt("isChose4507", isChose4507);
        PlayerPrefs.SetInt("isChose19997", isChose19997);
        PlayerPrefs.SetInt("isChose36507", isChose36507);
        PlayerPrefs.SetInt("isChose55557", isChose55557);
        PlayerPrefs.SetInt("isChose75007", isChose75007);
        PlayerPrefs.SetInt("isChose99997", isChose99997);

        is1008 = 0;
        is4508 = 0;
        is19998 = 1;
        is36508 = 0;
        is55558 = 0;
        is75008 = 0;
        is99998 = 0;

        PlayerPrefs.SetInt("is1008", is1008);
        PlayerPrefs.SetInt("is4508", is4508);
        PlayerPrefs.SetInt("is19998", is19998);
        PlayerPrefs.SetInt("is36508", is36508);
        PlayerPrefs.SetInt("is55558", is55558);
        PlayerPrefs.SetInt("is75008", is75008);
        PlayerPrefs.SetInt("is99998", is99998);

        select1lvl.SetActive(false);
        select2lvl.SetActive(false);
        select3lvl.SetActive(true);
        select4lvl.SetActive(false);
        select5lvl.SetActive(false);
        select6lvl.SetActive(false);
        select7lvl.SetActive(false);
        
        buy3lvl.SetActive(false);
    }

    public void isSelect340()
    {

        isChose1007 = 0;
        isChose4507 = 0;
        isChose19997 = 0;
        isChose36507 = 1;
        isChose55557 = 0;
        isChose75007 = 0;
        isChose99997 = 0;

        PlayerPrefs.SetInt("isChose1007", isChose1007);
        PlayerPrefs.SetInt("isChose4507", isChose4507);
        PlayerPrefs.SetInt("isChose19997", isChose19997);
        PlayerPrefs.SetInt("isChose36507", isChose36507);
        PlayerPrefs.SetInt("isChose55557", isChose55557);
        PlayerPrefs.SetInt("isChose75007", isChose75007);
        PlayerPrefs.SetInt("isChose99997", isChose99997);

        is1008 = 0;
        is4508 = 0;
        is19998 = 0;
        is36508 = 1;
        is55558 = 0;
        is75008 = 0;
        is99998 = 0;

        PlayerPrefs.SetInt("is1008", is1008);
        PlayerPrefs.SetInt("is4508", is4508);
        PlayerPrefs.SetInt("is19998", is19998);
        PlayerPrefs.SetInt("is36508", is36508);
        PlayerPrefs.SetInt("is55558", is55558);
        PlayerPrefs.SetInt("is75008", is75008);
        PlayerPrefs.SetInt("is99998", is99998);

        select1lvl.SetActive(false);
        select2lvl.SetActive(false);
        select3lvl.SetActive(false);
        select4lvl.SetActive(true);
        select5lvl.SetActive(false);
        select6lvl.SetActive(false);
        select7lvl.SetActive(false);
        
        buy4lvl.SetActive(false);
    }

    public void isSelect5555()
    {

        isChose1007 = 0;
        isChose4507 = 0;
        isChose19997 = 0;
        isChose36507 = 0;
        isChose55557 = 1;
        isChose75007 = 0;
        isChose99997 = 0;

        PlayerPrefs.SetInt("isChose1007", isChose1007);
        PlayerPrefs.SetInt("isChose4507", isChose4507);
        PlayerPrefs.SetInt("isChose19997", isChose19997);
        PlayerPrefs.SetInt("isChose36507", isChose36507);
        PlayerPrefs.SetInt("isChose55557", isChose55557);
        PlayerPrefs.SetInt("isChose75007", isChose75007);
        PlayerPrefs.SetInt("isChose99997", isChose99997);

        is1008 = 0;
        is4508 = 0;
        is19998 = 0;
        is36508 = 0;
        is55558 = 1;
        is75008 = 0;
        is99998 = 0;

        PlayerPrefs.SetInt("is1008", is1008);
        PlayerPrefs.SetInt("is4508", is4508);
        PlayerPrefs.SetInt("is19998", is19998);
        PlayerPrefs.SetInt("is36508", is36508);
        PlayerPrefs.SetInt("is55558", is55558);
        PlayerPrefs.SetInt("is75008", is75008);
        PlayerPrefs.SetInt("is99998", is99998);

        select1lvl.SetActive(false);
        select2lvl.SetActive(false);
        select3lvl.SetActive(false);
        select4lvl.SetActive(false);
        select5lvl.SetActive(true);
        select6lvl.SetActive(false);
        select7lvl.SetActive(false);
        
        buy5lvl.SetActive(false);
    }

    public void isSelect7500()
    {

        isChose1007 = 0;
        isChose4507 = 0;
        isChose19997 = 0;
        isChose36507 = 0;
        isChose55557 = 0;
        isChose75007 = 1;
        isChose99997 = 0;

        PlayerPrefs.SetInt("isChose1007", isChose1007);
        PlayerPrefs.SetInt("isChose4507", isChose4507);
        PlayerPrefs.SetInt("isChose19997", isChose19997);
        PlayerPrefs.SetInt("isChose36507", isChose36507);
        PlayerPrefs.SetInt("isChose55557", isChose55557);
        PlayerPrefs.SetInt("isChose75007", isChose75007);
        PlayerPrefs.SetInt("isChose99997", isChose99997);

        is1008 = 0;
        is4508 = 0;
        is19998 = 0;
        is36508 = 0;
        is55558 = 0;
        is75008 = 1;
        is99998 = 0;

        PlayerPrefs.SetInt("is1008", is1008);
        PlayerPrefs.SetInt("is4508", is4508);
        PlayerPrefs.SetInt("is19998", is19998);
        PlayerPrefs.SetInt("is36508", is36508);
        PlayerPrefs.SetInt("is55558", is55558);
        PlayerPrefs.SetInt("is75008", is75008);
        PlayerPrefs.SetInt("is99998", is99998);

        select1lvl.SetActive(false);
        select2lvl.SetActive(false);
        select3lvl.SetActive(false);
        select4lvl.SetActive(false);
        select5lvl.SetActive(false);
        select6lvl.SetActive(true);
        select7lvl.SetActive(false);
        
        buy6lvl.SetActive(false);
    }

    public void isSelect9999()
    {

        isChose1007 = 0;
        isChose4507 = 0;
        isChose19997 = 0;
        isChose36507 = 0;
        isChose55557 = 0;
        isChose75007 = 0;
        isChose99997 = 1;

        PlayerPrefs.SetInt("isChose1007", isChose1007);
        PlayerPrefs.SetInt("isChose4507", isChose4507);
        PlayerPrefs.SetInt("isChose19997", isChose19997);
        PlayerPrefs.SetInt("isChose36507", isChose36507);
        PlayerPrefs.SetInt("isChose55557", isChose55557);
        PlayerPrefs.SetInt("isChose75007", isChose75007);
        PlayerPrefs.SetInt("isChose99997", isChose99997);

        is1008 = 0;
        is4508 = 0;
        is19998 = 0;
        is36508 = 0;
        is55558 = 0;
        is75008 = 0;
        is99998 = 1;

        PlayerPrefs.SetInt("is1008", is1008);
        PlayerPrefs.SetInt("is4508", is4508);
        PlayerPrefs.SetInt("is19998", is19998);
        PlayerPrefs.SetInt("is36508", is36508);
        PlayerPrefs.SetInt("is55558", is55558);
        PlayerPrefs.SetInt("is75008", is75008);
        PlayerPrefs.SetInt("is99998", is99998);

        select1lvl.SetActive(false);
        select2lvl.SetActive(false);
        select3lvl.SetActive(false);
        select4lvl.SetActive(false);
        select5lvl.SetActive(false);
        select6lvl.SetActive(false);
        select7lvl.SetActive(true);
        
        buy7lvl.SetActive(false);
    }
}
