using TMPro;
using UnityEngine;

public class QuestionsManager : MonoBehaviour
{
    [SerializeField] TMP_Text question;
    [SerializeField] TMP_InputField answer;

    public int correctAnswer;


    // Start is called before the first frame update
    void Start()
    {
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerateQuestion()
    {
        (string qt, int ans) = GenerateAddSubtraction();
        question.text = qt;
        ClearTextInput();
        answer.Select();

    }

    private (string question, int answer) GenerateAddSubtraction()
    {
        int operand1 = Random.Range(0, 100);
        int operand2 = Random.Range(0, 100);
        string randomQuestion;

        if (Random.value < 0.5)
        {
            randomQuestion = $"{operand1} + {operand2} = ?";
            correctAnswer = operand1 + operand2;
        }
        else
        {
            randomQuestion = $"{operand1} - {operand2} = ?";
            correctAnswer = operand1 - operand2;
        }

        return (randomQuestion, correctAnswer);
    }

    public void ValidateAnswer()
    {
        if (correctAnswer.ToString() == answer.text)
        {
            GenerateQuestion();
        }
        else
        {
            ClearTextInput();
        }
    }

    void ClearTextInput()
    {
        answer.text = string.Empty;
        answer.ActivateInputField();
    }
}
