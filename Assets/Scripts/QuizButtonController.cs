using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizButtonController : MonoBehaviour
{
    public Text choiceText;

    public void OnChoiceButtonCLicked()
    {
        if (QuizController.instance.hasAnswered == false)
        {
            QuizController.instance.choosenAnswer = choiceText.text;
            QuizUIController.instance.ResetAllButtonColor();
            QuizUIController.instance.selectedButtonImage = this.GetComponent<Image>();
            QuizUIController.instance.SetSelectedButtonColor(BUTTON_COLOR.YELLOW);
        }

        SoundController.instance.PlaySound(SOUND.SELECT);
    }
}
