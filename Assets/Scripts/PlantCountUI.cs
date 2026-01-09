using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    [SerializeField] private string _plantedTextLabel;
    [SerializeField] private string _remainingTextLabel;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _plantedText.text = _plantedTextLabel + seedsPlanted.ToString();
        _remainingText.text = _remainingTextLabel + seedsLeft.ToString();
    }
}