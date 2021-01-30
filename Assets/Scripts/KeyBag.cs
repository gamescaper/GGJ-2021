using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBag : MonoBehaviour
{
    int numOfKeys = 0;
    public string keyTag = "Key";
    public string doorTag = "Door";
    public Text numOfKeysText;
    private void OnTriggerEnter(Collider col) {
        Debug.Log("HIGH");
        if (col.gameObject.CompareTag(keyTag)) {
            col.gameObject.SetActive(false);
            numOfKeys++;
        }
        else if (col.gameObject.CompareTag(doorTag) && numOfKeys > 0) {
            col.gameObject.transform.parent.gameObject.GetComponent<Open>().enabled = true;
            numOfKeys--;
        }
        numOfKeysText.text = numOfKeys+"";
    }
}
