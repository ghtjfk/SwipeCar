using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float moveSpeed = 0f;
    bool isMove = false;
    Vector2 startPos;   //시작 지점을 저장할 변수
   
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
            Vector2 endPos = Input.mousePosition;   //메모리 최소화를 위해 endPos는 여기서 정의
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
