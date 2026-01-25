using UnityEngine;

public class CallItem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] ItemData item;
    void Start()
    {
        Debug.Log(item.name);

        int moneyMade = item.SellItem(2);

        Debug.Log("Money made:" + moneyMade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
