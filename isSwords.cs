using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class isSwords : MonoBehaviour
{
    public int Count100 = 40, Count450 = 40, Count1999 = 40, Count3650 = 40, Count5555 = 40, Count7500 = 40, Count9999 = 40;

    public TextMeshProUGUI text1;


    public static int upsColvo10023 = 0, upsColvo45023 = 0, upsColvo199923 = 0, upsColvo365023 = 0, upsColvo555523 = 0, upsColvo750023 = 0, upsColvo999923 = 0;
    public  GameObject lvl1Select;
    public  GameObject lvl2Select;
    public GameObject lvl3Select;
    public GameObject lvl4Select;
    public  GameObject lvl5Select;
    public GameObject lvl6Select;
    public GameObject lvl7Select;
    public GameObject PanelChange;
    public GameObject UpgPanel;
    public int isActive100 = 0, isActive450 = 0, isActive1999 = 0, isActive3650 = 0, isActive5555 = 0, isActive7500 = 0, isActive9999 = 0;
    public static int UpsCount1009 = 1, UpsCount4509 = 1, UpsCount19999 = 1, UpsCount36509 = 1, UpsCount55559 = 1, UpsCount75009 = 1, UpsCount99999 = 1;
    public int eeeeerq = 0, eeeeerq1 = 0, eeeeerq2 = 0, eeeeerq3 = 0, eeeeerq4 = 0, eeeeerq5 = 0, eeeeerq6 = 0;
    public static int CoinsEnoght100 = 0, CoinsEnoght450 = 0, CoinsEnoght1999 = 0, CoinsEnoght3650 = 0, CoinsEnoght5555 = 0, CoinsEnoght7500 = 0, CoinsEnoght9999 = 0;
    public TextMeshProUGUI text1Cost;
    public  GameObject lvl1;
    public  GameObject lvl2;
    public GameObject lvl3;
    public GameObject lvl4;
    public  GameObject lvl5;
    public GameObject lvl6;
    public GameObject lvl7;

    private void Awake() 
    {
        UpsCount1009 = PlayerPrefs.GetInt("UpsCount1009", 1);
        UpsCount4509 = PlayerPrefs.GetInt("UpsCount4509", 1);
        UpsCount19999 = PlayerPrefs.GetInt("UpsCount19999", 1);
        UpsCount36509 = PlayerPrefs.GetInt("UpsCount36509", 1);
        UpsCount55559 = PlayerPrefs.GetInt("UpsCount55559", 1);
        UpsCount75009 = PlayerPrefs.GetInt("UpsCount75009", 1);
        UpsCount99999 = PlayerPrefs.GetInt("UpsCount99999", 1);

    }

    public void isActiveChest1()
    {
        if(SwordScripts.BB100def995 == 2)
        {
            lvl1.SetActive(true);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
        }
    }  

    public void isActiveChest2()
    {
        if(SwordScripts.BB450def995 == 2)
        {
            lvl1.SetActive(true);
            lvl2.SetActive(true);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
        }
    }

    public void isActiveChest3()
    {
        if(SwordScripts.BB1999def995 == 2)
        {
            lvl1.SetActive(true);
            lvl2.SetActive(true);
            lvl3.SetActive(true);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
        }
    }

    public void isActiveChest4()
    {
        if(SwordScripts.BB3650def995 == 2)
        {
            lvl1.SetActive(true);
            lvl2.SetActive(true);
            lvl3.SetActive(true);
            lvl4.SetActive(true);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
        }
    } 

    public void isActiveChest5()
    {
        if(SwordScripts.BB5555def995 == 2)
        {
            lvl1.SetActive(true);
            lvl2.SetActive(true);
            lvl3.SetActive(true);
            lvl4.SetActive(true);
            lvl5.SetActive(true);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
        }
    } 

    public void isActiveChest6()
    {
        if(SwordScripts.BB7500def995 == 2)
        {
            lvl1.SetActive(true);
            lvl2.SetActive(true);
            lvl3.SetActive(true);
            lvl4.SetActive(true);
            lvl5.SetActive(true);
            lvl6.SetActive(true);
            lvl7.SetActive(false);
        }
    } 

    public void isActiveChest7()
    {
        if(SwordScripts.BB9999def995 == 2)
        {
            lvl1.SetActive(true);
            lvl2.SetActive(true);
            lvl3.SetActive(true);
            lvl4.SetActive(true);
            lvl5.SetActive(true);
            lvl6.SetActive(true);
            lvl7.SetActive(true);
        }
    } 
    
    public void Slct200()
    {
        isActive100 = 1;
        isActive450 = 0;
        isActive1999 = 0;
        isActive3650 = 0;
        isActive5555 = 0;
        isActive7500 = 0;
        isActive9999 = 0;

        PanelChange.SetActive(false);
        UpgPanel.SetActive(true);
        lvl1Select.SetActive(true);
    }

    public void Slct250()
    {
        isActive450 = 1;
        isActive100 = 0;
        isActive1999 = 0;
        isActive3650 = 0;
        isActive5555 = 0;
        isActive7500 = 0;
        isActive9999 = 0;

        PanelChange.SetActive(false);
        UpgPanel.SetActive(true);
        lvl2Select.SetActive(true);
    }

    public void Slct290()
    {
        isActive1999 = 1;
        isActive450 = 0;
        isActive100 = 0;
        isActive3650 = 0;
        isActive5555 = 0;
        isActive7500 = 0;
        isActive9999 = 0;

        PanelChange.SetActive(false);
        UpgPanel.SetActive(true);
        lvl3Select.SetActive(true);
    }

    public void Slct340()
    {
        isActive100 = 0;
        isActive450 = 0;
        isActive1999 = 0;
        isActive3650 = 1;
        isActive5555 = 0;
        isActive7500 = 0;
        isActive9999 = 0;

        PanelChange.SetActive(false);
        UpgPanel.SetActive(true);
        lvl4Select.SetActive(true);
    }

    public void Slct5555()
    {
        isActive100 = 0;
        isActive450 = 0;
        isActive1999 = 0;
        isActive3650 = 0;
        isActive5555 = 1;
        isActive7500 = 0;
        isActive9999 = 0;
        
        PanelChange.SetActive(false);
        UpgPanel.SetActive(true);
        lvl5Select.SetActive(true);
    }

    public void Slct7500()
    {
        isActive100 = 0;
        isActive450 = 0;
        isActive1999 = 0;
        isActive3650 = 0;
        isActive5555 = 0;
        isActive7500 = 1;
        isActive9999 = 0;
        
        PanelChange.SetActive(false);
        UpgPanel.SetActive(true);
        lvl6Select.SetActive(true);
    }

    public void Slct9999()
    {
        isActive100 = 0;
        isActive450 = 0;
        isActive1999 = 0;
        isActive3650 = 0;
        isActive5555 = 0;
        isActive7500 = 0;
        isActive9999 = 1;
        
        PanelChange.SetActive(false);
        UpgPanel.SetActive(true);
        lvl7Select.SetActive(true);
    }
    public void ondN()
    {
        if(SwordScripts.BB9999def995 != 2 &&  SwordScripts.BB7500def995 != 2 && SwordScripts.BB100def995 != 2 && SwordScripts.BB5555def995 != 2 &&  SwordScripts.BB3650def995 != 2 && SwordScripts.BB1999def995 != 2 && SwordScripts.BB450def995 != 2)
            PanelChange.SetActive(false);
    }

    private void FixedUpdate()
    {
        if(SwordScripts.BB9999def995 != 2 &&  SwordScripts.BB7500def995 != 2 && SwordScripts.BB100def995 != 2 && SwordScripts.BB5555def995 != 2 &&  SwordScripts.BB3650def995 != 2 && SwordScripts.BB1999def995 != 2 && SwordScripts.BB450def995 != 2)
            PanelChange.SetActive(false);





        if(Count100 < 40)
            Count100 +=1;

        if(Count450 < 40)
            Count450 +=1;

        if(Count1999 < 40)
            Count1999 +=1;

        if(Count3650 < 40)    
            Count3650 +=1;

        if(Count5555 < 40)
            Count5555 +=1;

        if(Count7500 < 40)
            Count7500 +=1;

        if(Count9999 < 40)
            Count9999 +=1;
    }

    public void Up200()
    {
        if(ChangeClicks.CocoTins >= (UpsCount1009+1) * 200 && isActive100 == 1 && Count100 == 40)
        {
            CoinsEnoght100 += 1;
            UpsCount1009 += 1;
            upsColvo10023 += UpsCount1009 * 200;
            PlayerPrefs.SetInt("UpsCount1009", UpsCount1009);
            ClickMouseCount.Plus10092 = 0;
            Count100 = 0;
        }
    }

    public void Up250()
    {
        if(ChangeClicks.CocoTins >= (UpsCount4509+1) * 300 && isActive450 == 1 && Count450 == 40)
        {
            CoinsEnoght450 += 1;
            UpsCount4509 += 1;
            upsColvo45023 += UpsCount4509 * 300;
            PlayerPrefs.SetInt("UpsCount4509", UpsCount4509);
            ClickMouseCount.Plus45092 = 0;
            Count450 = 0;
        }
    }

    public void Up290()
    {
        if(ChangeClicks.CocoTins >= (UpsCount19999+1) * 600 && isActive1999 == 1 && Count1999 == 40)
        {
            CoinsEnoght1999 += 1;
            UpsCount19999 += 1;
            upsColvo199923 += UpsCount19999 * 600;
            PlayerPrefs.SetInt("UpsCount19999", UpsCount19999);
            ClickMouseCount.Plus199992 = 0;
            Count1999 = 0;
        }
    }

    public void Up340()
    {
        if(ChangeClicks.CocoTins >= (UpsCount36509+1) * 1000 && isActive3650 == 1 && Count3650 == 40)
        {
            CoinsEnoght3650 += 1;
            UpsCount36509 += 1;
            upsColvo365023 += UpsCount36509 * 1000;
            PlayerPrefs.SetInt("UpsCount36509", UpsCount36509);
            ClickMouseCount.Plus365092 = 0;
            Count3650 = 0;
        }
    }

    public void Up5555()
    {
        if(ChangeClicks.CocoTins >= (UpsCount55559+1) * 2000 && isActive5555 == 1 && Count5555 == 40)
        {
            CoinsEnoght5555 += 1;
            UpsCount55559 += 1;
            upsColvo555523 += UpsCount55559 * 2000;
            PlayerPrefs.SetInt("UpsCount55559", UpsCount55559);
            ClickMouseCount.Plus555592 = 0;
            Count5555 = 0;
        }
    }

    public void Up7500()
    {
        if(ChangeClicks.CocoTins >= (UpsCount75009+1) * 3000 && isActive7500 == 1 && Count7500 == 40)
        {
            CoinsEnoght7500 += 1;
            UpsCount75009 += 1;
            upsColvo750023 += UpsCount75009 * 3000;
            PlayerPrefs.SetInt("UpsCount75009", UpsCount75009);
            ClickMouseCount.Plus750092 = 0;
            Count7500 = 0;
        }
    }

    public void Up9999()
    {
        if(ChangeClicks.CocoTins >= (UpsCount99999+1) * 5000 && isActive9999 == 1 && Count9999 == 40)
        {
            CoinsEnoght9999 += 1;
            UpsCount99999 += 1;
            upsColvo999923 += UpsCount99999 * 5000;
            PlayerPrefs.SetInt("UpsCount99999", UpsCount99999);
            ClickMouseCount.Plus999992 = 0;
            Count9999 = 0;
        }
    }

    private void Update() 
    {
        if(isActive100 == 1)
        {
            text1.text = (25 + (UpsCount1009+1) * 5).ToString();
        }

        if(isActive450 == 1)
        {
            text1.text = (63 + (UpsCount4509+1) * 7).ToString();
        }

        if(isActive1999 == 1)
        {
            text1.text = (103 + (UpsCount19999+1) * 12).ToString();
        }

        if(isActive3650 == 1)
        {
            text1.text = (133 + (UpsCount36509+1) * 17).ToString();
        }

        if(isActive5555 == 1)
        {
            text1.text = (154 + (UpsCount55559+1) * 26).ToString();
        }

        if(isActive7500 == 1)
        {
            text1.text = (176 + (UpsCount75009+1) * 34).ToString();
        }

        if(isActive9999 == 1)
        {
            text1.text = (244 + (UpsCount99999+1) * 41).ToString();
        }





        if(CoinsEnoght100 == 0)
            upsColvo10023 = 0;

        if(CoinsEnoght450 == 0)
            upsColvo45023 = 0;

        if(CoinsEnoght1999 == 0)
            upsColvo199923 = 0;

        if(CoinsEnoght3650 == 0)
            upsColvo365023 = 0;

        if(CoinsEnoght5555 == 0)
            upsColvo555523 = 0;

        if(CoinsEnoght7500 == 0)
            upsColvo750023 = 0;

        if(CoinsEnoght9999 == 0)
            upsColvo999923 = 0;

        if(isActive100 == 1)
            text1Cost.text = ((UpsCount1009 +1) * 200).ToString();
        
        if(isActive450 == 1)
            text1Cost.text = ((UpsCount4509 +1) * 300).ToString();

        if(isActive1999 == 1)
            text1Cost.text = ((UpsCount19999 +1) * 600).ToString();

        if(isActive3650 == 1)
            text1Cost.text = ((UpsCount36509 +1) * 1000).ToString();
        
        if(isActive5555 == 1)
            text1Cost.text = ((UpsCount55559 +1) * 2000).ToString();

        if(isActive7500 == 1)
            text1Cost.text = ((UpsCount75009 +1) * 3000).ToString();

        if(isActive9999 == 1)
            text1Cost.text = ((UpsCount99999 +1) * 5000).ToString();
        
        eeeeerq = UpsCount1009;    
        eeeeerq1 = UpsCount4509;  
        eeeeerq2 = UpsCount19999;  
        eeeeerq3 = UpsCount36509;  
        eeeeerq4 = UpsCount55559;
        eeeeerq5 = UpsCount75009;
        eeeeerq6 = UpsCount99999;
    }
}