using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppraisalManager : MonoBehaviour
{
    public MagicItem magicItem;
    public GameObject magicItemGo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AcceptItem() {
        Debug.Log("Accept");

        StartCoroutine(GenerateItem());
    }

    public void DenyItem() {
        Debug.Log("Deny");

        StartCoroutine(GenerateItem());
    }

    private IEnumerator GenerateItem() {
        yield return new WaitForSeconds(0.5f);
        
        magicItem = new RingItem();

        yield return null;
    }
}
