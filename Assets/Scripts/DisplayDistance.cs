using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayDistance : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI _distanceText;
    [SerializeField] private Transform _playerTrans;

    private Vector2 _startPosition;
    void Start()
    {
        _startPosition = _playerTrans.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 distance = (Vector2) _playerTrans.position - _startPosition;
        distance.y = 0f;

        if(distance.x <0)
        {
            distance.x = 0;
        }
        _distanceText.text = distance.x.ToString("F0") + "m";
    }
}
