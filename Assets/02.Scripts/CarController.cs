using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float moveSpeed = 0f;
    bool isMove = false;
    Vector2 startPos;   //���� ������ ������ ����
   
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isMove.Equals(false))
        {
            startPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0) && isMove.Equals(false))
        {
            Vector2 endPos = Input.mousePosition;   //�޸� �ּ�ȭ�� ���� endPos�� ���⼭ ����
            float swipeLength = Mathf.Abs(endPos.x - startPos.x);
            moveSpeed = swipeLength / 1000f;
            isMove = true;
        }

        transform.Translate(moveSpeed, 0, 0);
        moveSpeed *= 0.97f;
        if (moveSpeed < 0.01f)
        {
            moveSpeed = 0;
        }

        if(Input.GetMouseButtonDown(1) && moveSpeed == 0)
        {
            transform.position = new Vector3(-7f, -3.7f, 0);
            isMove = false;
        }
    }
}
