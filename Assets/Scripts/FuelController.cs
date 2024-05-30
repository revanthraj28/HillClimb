using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    public static FuelController instance;
    [SerializeField] private Image _fuelImage;
    [SerializeField, Range(0.1f, 5f)] private float _fuelDrainSpeed = 20f;
    [SerializeField] private float _maximunFuelAmount = 100f;

    [SerializeField] private Gradient _fuelGradient;

    private float _currentFuelAmount;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        _currentFuelAmount = _maximunFuelAmount;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        _currentFuelAmount -= Time.deltaTime * _fuelDrainSpeed;
        UpdateUI();

        if (_currentFuelAmount <= 0f)
        {
            Gamemanager.instance.GameOver();
        }

    }

    public void FillFull()
    {
        _currentFuelAmount = _maximunFuelAmount;
        UpdateUI();
    }
    public void UpdateUI()
    {
        _fuelImage.fillAmount = (_currentFuelAmount / _maximunFuelAmount);
        _fuelImage.color = _fuelGradient.Evaluate(_fuelImage.fillAmount);
    }
}
