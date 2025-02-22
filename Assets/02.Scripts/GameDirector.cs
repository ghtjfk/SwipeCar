using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public Text distance_Text;

    void Start()
    {
        
    }

   
    void Update()
    {
        float distance = flag.transform.position.x - car.transform.position.x;
        if (distance >= 0) distance_Text.text = "��ǥ �������� : " + distance.ToString("F2") + "m";
        else distance_Text.text = "���� ����";
    }
}
