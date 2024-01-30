using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public int kek = 0, kek1 = 0, kek2 = 0;
    public int WQ1 = 0, WQ2 = 0, WQ3 = 0;
    public int WQ12 = 0, WQ22 = 0, WQ32 = 0;
    public static int LL = 10;
    public int EnemDMGG = 0;
    public static int EnemDMG = 1;
    public int CountKill = 0;
    public static int CountKilledEnemies = 0;
    public static int eff1 = 0;
    public static int eff11 = 0;
    public static int eff12 = 0;




    public static int ass1 = 0;
    public static float Attas = 0.0f;
    public int k = 0;
    public static int Cm = 0; 

    public int o = 0, y = 0;
    public int o1 = 0, y1 = 0;
    public int o2 = 0, y2 = 0;
    public int n = 0;
    public GameObject prefab;
    public GameObject targetObject;
    public float distanceThreshold = 1.5f;
    public int prefabHealth = 200; 

    public float moveSpeed = 4.45f;
    public float checkGroundOffsetY = -1.5f;
    public float checkGroundRadius = 3f;


    public int p = 1;

    public int p1 = 1;

    GameObject[] prefabs;



    public void UpUpUpEnemies()
    {
        if(CountKilledEnemies >= LL && CountKilledEnemies < (LL+10) && CountKilledEnemies < 25)
        {
            prefabHealth += 100;
            EnemDMG += 1;
            LL += 10;
        }

    }


    void FixedUpdate()
    {
        WQ1 = PLayerMovee.EFFectFroz;
        WQ2 = PLayerMovee.EFFectFire;
        WQ3 = PLayerMovee.EFFectOtrava;

        WQ12 = PLayerMovee.EFFectFroz1;
        WQ22 = PLayerMovee.EFFectFire1;
        WQ32 = PLayerMovee.EFFectOtrava1;

        EnemDMGG = EnemDMG;
        CountKill = CountKilledEnemies;
        UpUpUpEnemies();


      //  if(p == 1 && PLayerMovee.EFFectFire == 2000)
         //   p = 0;



       // if(p1 == 1 && PLayerMovee.EFFectOtrava == 3000)
          //  p1 = 0;

      //  if(PLayerMovee.EFFectOtrava == 0 && PLayerMovee.EFFectOtrava1 < 150)    
          //  PLayerMovee.EFFectOtrava1++;
    
        k++;
        Vector3 XS = new Vector3(10, 0, 0);

        if (k >= 200 && PLayerMovee.CountOfEnemies <= 14 && CountKilledEnemies < 25) 
        {
            PLayerMovee.CountOfEnemies += 1;           
            GameObject prefabInstance = Instantiate(prefab, transform.position +XS, Quaternion.identity);
            Debug.Log("Префаб создан");
            n += 1;
            Bounds targetBounds = targetObject.GetComponent<Renderer>().bounds;
            k = 0;
        }
            prefabs = GameObject.FindGameObjectsWithTag("Prefab"); 
            

            // Перемещаем все созданные префабы в сторону целевого объекта

        foreach (GameObject prefabInstance in prefabs)
        {
            // Вычисляем направление и расстояние до целевого объекта
            Vector3 direction = targetObject.transform.position - prefabInstance.transform.position;
            float distance = direction.magnitude;

            // Если расстояние больше некоторого значения (например, 1 единицы),
            // перемещаем префаб в сторону целевого объекта
            if (distance > 1f)
            {
                // Нормализуем направление для постоянной скорости перемещения
                direction.Normalize();

                // Перемещаем префаб в сторону целевого объекта с учетом скорости
                prefabInstance.transform.Translate(direction * moveSpeed * Time.deltaTime);
            }
            // Добавляем компонент PrefabHealth и устанавливаем его значение равным prefabHealth
            PrefabHealth prefabHealthComponent = prefabInstance.AddComponent<PrefabHealth>();
            prefabHealthComponent.health = prefabHealth;
        }




        if(PLayerMovee.EFFectFroz1 == 0)
        {
            eff1 = 0;
            moveSpeed = 4.45f;
        }



        if(PLayerMovee.EFFectFire1 == 0)
        {
            eff11 = 0;
        }




        if(PLayerMovee.EFFectOtrava1 == 0)
        {
            eff12 = 0;
        }

        

        if( PLayerMovee.EFFectFroz1 < 200 && PLayerMovee.EFFectFroz == 1250  && eff11 == 0 && eff12 == 0)
        {
        Frozen();
        }




        if( PLayerMovee.EFFectFire1 <= 150 && PLayerMovee.EFFectFire == 2000   && eff1 == 0 && eff12 == 0)
        {
        Fire();
        }




        if( PLayerMovee.EFFectOtrava1 <= 150 && PLayerMovee.EFFectOtrava == 3000   && eff1 == 0 && eff11 == 0)
        {
        Otrava();
        }


    }

    public void Frozen()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll
            (new Vector2(transform.position.x, transform.position.y + checkGroundOffsetY), checkGroundRadius);
        for (int i = 0; i < hitColliders.Length; i++)
        {
            PrefabHealth prefabHealthComponent = hitColliders[i].gameObject.GetComponent<PrefabHealth>();
            if( PLayerMovee.EFFectFroz1 < 200 && PLayerMovee.EFFectFroz == 1250  && eff11 == 0 && eff12 == 0)
            {
                
                eff1 = 1;
                moveSpeed = 0f;
                if(kek < 1 && prefabHealthComponent != null)
                    prefabHealthComponent.FrozDmg();

                kek++;
                // PLayerMovee.EFFectFroz = 0;
                // PLayerMovee.EFFectFroz1 = 0;
                //  if (prefabHealthComponent.health <= 0)
                //  {
                //     CountKilledEnemies += 1;
                //     PLayerMovee.CountOfEnemies -= 1;
                //     Cm += 100 * 1;
                //     Destroy(hitColliders[i].gameObject);
                //  }
            }
            else
                kek = 0;
        }
    }




    public void Fire()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll
            (new Vector2(transform.position.x, transform.position.y + checkGroundOffsetY), checkGroundRadius);
        for (int i = 0; i < hitColliders.Length; i++)
        {
            PrefabHealth prefabHealthComponent = hitColliders[i].gameObject.GetComponent<PrefabHealth>();
            if( PLayerMovee.EFFectFire1 <= 150 && PLayerMovee.EFFectFire == 2000   && eff1 == 0 && eff12 == 0)
            {
                
                PLayerMovee.p = 1;
                eff11 = 1;
                if(kek1 < 1 && prefabHealthComponent != null)
                    prefabHealthComponent.FireDmg();

                kek1 ++;
                //PLayerMovee.EFFectFire = 0;
                //PLayerMovee.EFFectFire1 = 0;
                // if (prefabHealthComponent.health <= 0)
                // {
                //     CountKilledEnemies += 1;
                //     PLayerMovee.CountOfEnemies -= 1;
                //     Cm += 100 * 1;
                //     Destroy(hitColliders[i].gameObject);
                // }
            }
            else
                kek1 = 0;
        }
    }

    public void Otrava()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll
            (new Vector2(transform.position.x, transform.position.y + checkGroundOffsetY), checkGroundRadius);
        for (int i = 0; i < hitColliders.Length; i++)
        {
            PrefabHealth prefabHealthComponent = hitColliders[i].gameObject.GetComponent<PrefabHealth>();
            if( PLayerMovee.EFFectOtrava1 <= 150 && PLayerMovee.EFFectOtrava == 3000   && eff1 == 0 && eff11 == 0)
            {
                
                PLayerMovee.p1 = 1;
                eff12 = 1;
                if(kek2 <= 3 && prefabHealthComponent != null)
                    prefabHealthComponent.OtravaDmg();

                kek2++;
               // PLayerMovee.EFFectOtrava = 0;
               // PLayerMovee.EFFectOtrava1 = 0;
                // if (prefabHealthComponent.health <= 0)
                // {
                //     CountKilledEnemies += 1;
                //     PLayerMovee.CountOfEnemies -= 1;
                //     Cm += 100 * 1;
                //     Destroy(hitColliders[i].gameObject);
                // }
            }
            else 
                kek2 = 0;
        }
    }

    public void DestroyNearbyObjects()
    {
            Attas = 1.0f;

        Collider2D[] hitColliders = Physics2D.OverlapCircleAll
            (new Vector2(transform.position.x, transform.position.y + checkGroundOffsetY), checkGroundRadius);
        for (int i = 0; i < hitColliders.Length; i++)
        {
                PrefabHealth prefabHealthComponent = hitColliders[i].gameObject.GetComponent<PrefabHealth>();
                if (prefabHealthComponent != null)
                {
                    prefabHealthComponent.TakeDamage();
                    if (prefabHealthComponent.health <= 0)
                    {
                        CountKilledEnemies += 1;
                        PLayerMovee.CountOfEnemies -= 1;  
                        Cm += 5 * 1;
                        Destroy(hitColliders[i].gameObject);
                        n = 0;
                    }
                }
        }
        Debug.Log("Рядом с объектом были уничтожены объекты");
    }

}

public class PrefabHealth : MonoBehaviour
{
    public int health = 200;

    public void TakeDamage()
    {
        health-= ClickMouseCount.po24;
        Debug.Log("У префаба осталось здоровья: " + health);
    }

    public void FrozDmg()
    {
        health -= 1;
    }
    public void FireDmg()
    {
        health -= 10;
    }

    public void OtravaDmg()
    {
        health -= 3;
    }
}
   
 