using System.Collections;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float smooth;
    private bool isMove;

    private void Update()
    {
        StartCoroutine(Move());
    } 
     
    IEnumerator Move()
    {
        if (isMove)
        {
            transform.Rotate(0, 0, 1.2f);
            yield return new WaitForSeconds(3);
            isMove = false;
        }
        if (isMove == false)
        {
            transform.Rotate(0, 0, -1.2f);
            yield return new WaitForSeconds(3);
            isMove = true;
        }
    }
}
