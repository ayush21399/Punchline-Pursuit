using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public TextMeshProUGUI quizText;
    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public Button startButton;
    public Button exitButton;

    private Question[] questions;
    private int currentQuestionIndex = 0;
    private int correctAnswers = 0;
    private bool isQuizActive = false;
    private bool co = true;

    [System.Serializable]
    public class Question
    {
        public string questionText;
        public string[] answerOptions;
        public int correctAnswerIndex;
    }

    private void Start()
    {
        startButton.onClick.AddListener(StartQuiz);
        exitButton.onClick.AddListener(ExitQuiz);
        questions = new Question[]
        {
            new Question
            {
                questionText = "Why did the scarecrow become a successful stand-up comedian?",
                answerOptions = new string[] { "Because he had a great sense of humor.", "Because he was outstanding in his field.", "Because he loved corny jokes." },
                correctAnswerIndex = 1
            },
            new Question
            {
                questionText = "What do you call fake spaghetti?",
                answerOptions = new string[] { "An impasta.", "Spagh-phony.", "Noodle imposter." },
                correctAnswerIndex = 0
            },
            new Question
            {
                questionText = "Why don't scientists trust atoms?",
                answerOptions = new string[] { "Because they make up everything.", "Because they are too small to be seen.", "Because they're always changing." },
                correctAnswerIndex = 0
            },
            new Question
            {
                questionText = "What's a vampire's favorite fruit?",
                answerOptions = new string[] { "Blood oranges.", "Vampberries.", "Dracufruit." },
                correctAnswerIndex = 0
            },
            new Question
            {
                questionText = "Why did the bicycle fall over?",
                answerOptions = new string[] { "Because it was tired.", "Because it had a flat tire.", "Because it was two-tired." },
                correctAnswerIndex = 0
            },
                new Question
    {
        questionText = "What do you call a fish with no eyes?",
        answerOptions = new string[] { "Fish without eyes.", "Eyeless fish.", "Blindfish." },
        correctAnswerIndex = 0
    },
    new Question
    {
        questionText = "How do you organize a space party?",
        answerOptions = new string[] { "Astronaut celebration.", "You planet.", "Space disco." },
        correctAnswerIndex = 1
    },
    new Question
    {
        questionText = "What's a skeleton's least favorite room in the house?",
        answerOptions = new string[] { "The bathroom.", "The living room.", "The bedroom." },
        correctAnswerIndex = 2
    },
    new Question
    {
        questionText = "What did one ocean say to the other ocean?",
        answerOptions = new string[] { "Ocean conversation.", "You're so deep.", "Nothing, they just waved." },
        correctAnswerIndex = 2
    },
    new Question
    {
        questionText = "Why did the math book look sad?",
        answerOptions = new string[] { "Math book emotions.", "Because it had too many problems.", "It didn't like numbers." },
        correctAnswerIndex = 1
    },
    new Question
    {
        questionText = "What's brown and sticky?",
        answerOptions = new string[] { "Chocolate-covered tree.", "A stick.", "Molasses." },
        correctAnswerIndex = 1
    },
    new Question
    {
        questionText = "Why did the tomato turn red?",
        answerOptions = new string[] { "Tomato blushing.", "Sun exposure.", "Because it saw the salad dressing." },
        correctAnswerIndex = 0
    },
    new Question
    {
        questionText = "What do you call a bear with no teeth?",
        answerOptions = new string[] { "Toothless bear.", "A gummy bear.", "Bare gums." },
        correctAnswerIndex = 0
    },
    new Question
    {
        questionText = "How do you catch a squirrel?",
        answerOptions = new string[] { "With a net.", "Climb a tree and act like a nut.", "Squirrel trap." },
        correctAnswerIndex = 1
    },
    new Question
    {
        questionText = "Why did the chicken go to the seance?",
        answerOptions = new string[] { "Chicken curiosity.", "To talk to the other side.", "Spiritual awakening." },
        correctAnswerIndex = 1
    },
    new Question
    {
        questionText = "What did one hat say to the other?",
        answerOptions = new string[] { "Hat conversation.", "Stay here, I'm going on ahead.", "You're looking good." },
        correctAnswerIndex = 2
    },
    new Question
    {
        questionText = "What's orange and sounds like a parrot?",
        answerOptions = new string[] { "Orange mimic.", "A carrot.", "Parrot imitator." },
        correctAnswerIndex = 1
    },
    new Question
    {
        questionText = "Why don't skeletons fight each other?",
        answerOptions = new string[] { "Skeleton harmony.", "Bone peacekeepers.", "They don't have the guts." },
        correctAnswerIndex = 0
    },
    new Question
    {
        questionText = "How do you organize a space party?",
        answerOptions = new string[] { "Space disco.", "Astronaut celebration.", "You planet." },
        correctAnswerIndex = 1
    }
        };
       

        InitializeQuestion();
    }

    private void StartQuiz()
    {
        isQuizActive = true;
        co = false;
        startButton.gameObject.SetActive(false); // Hide the Start button
        InitializeQuestion();
    }
    private void ExitQuiz()
    {
        Application.Quit();
    }

    private void InitializeQuestion()
    {
        if (!isQuizActive || currentQuestionIndex >= questions.Length)
        {
            EndQuiz();
            return;
        }

        Question currentQuestion = questions[currentQuestionIndex];

        quizText.text = currentQuestion.questionText;

        buttonA.GetComponentInChildren<TextMeshProUGUI>().text = currentQuestion.answerOptions[0];
        buttonB.GetComponentInChildren<TextMeshProUGUI>().text = currentQuestion.answerOptions[1];
        buttonC.GetComponentInChildren<TextMeshProUGUI>().text = currentQuestion.answerOptions[2];
    }

    public void ChooseAnswer(int index)
    {
        if (!isQuizActive) return;

        Question currentQuestion = questions[currentQuestionIndex];

        if (index == currentQuestion.correctAnswerIndex)
        {
            correctAnswers++;
           // Debug.Log("Correct answer chosen!");
        }
        else
        {
           // Debug.Log("Wrong answer chosen!");
        }

        currentQuestionIndex++;

        // For simplicity, let's immediately initialize a new question after an answer
        InitializeQuestion();
    }

    private void EndQuiz()
    {
        isQuizActive = false; 
            if (isQuizActive == false && co == false)
            {
                quizText.text = $"Quiz completed!\nyou save the world and made them laugh again(PROBABLY) \nCorrect Answers: {correctAnswers}/{questions.Length}";
            }
        
    }

 
}
