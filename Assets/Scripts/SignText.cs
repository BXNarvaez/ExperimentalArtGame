using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignText : MonoBehaviour
{
    [SerializeField]
    Text _sign;
    [SerializeField]
    string _text;
    [SerializeField]
    Color _color;

    // Start is called before the first frame update
    void Start()
    {
        _sign = transform.GetChild(0).GetChild(0).GetComponent<Text>();
        _sign.text = _text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
