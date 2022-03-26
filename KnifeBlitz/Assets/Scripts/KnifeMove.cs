using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class KnifeMove : MonoBehaviour
{
    [SerializeField] private GameObject knifePrefab;
    [SerializeField] private float speed; 

    private float allKnife = 20;
    public TextMeshProUGUI text;
     

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        text.text = "" + allKnife;
        if (allKnife == 0)
        {
            SceneManager.LoadScene(0);
        }
    } 

    private void Shoot()
    {
        GameObject newKnife = Instantiate(knifePrefab, transform.position, transform.rotation);
        newKnife.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
        allKnife--;
    } 
}
