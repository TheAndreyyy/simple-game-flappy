using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float Max_Time = 1;
    public float Timer = 0;
    public GameObject Barriers;
    public GameObject coin;
    public float Height;
    public List<GameObject> barriersList;
    private void Start()
    {
        //barriersList = new List<GameObject>();
    }

    void Update()
    {
        if (Timer > Max_Time)
        {
            int random = Random.Range(0, 2);
            GameObject New_Barriers = Instantiate(Barriers);
            if (barriersList.Count > 2)
            {
                Destroy(barriersList[0]);
                barriersList.RemoveAt(0);
            }
            //for (int i = 0; i < barriersList.Count; i++)
            //{
            //    if (barriersList)
            //    {

            //    }
            //}
            barriersList.Add(New_Barriers);
            New_Barriers.transform.position = transform.position + new Vector3(0, Random.Range(-Height, Height), 0);
            //Destroy(New_Barriers, 15);
            if (random == 0)
            {
                GameObject newCoin = Instantiate(coin);
                newCoin.transform.position = New_Barriers.transform.position;
                //Destroy(newCoin, 15);

            }
            Timer = 0;
        }
        Timer += Time.deltaTime;
    }
}
