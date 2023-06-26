using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHander : MonoBehaviour
{
    public Button btnClick;
    public InputField nameInput;
    public Text HigherScoreText;

    public int score;


    

    // Start is called before the first frame update
    void Start()
    {
        // Button event
        btnClick.onClick.AddListener(GetButtonValue);
        GetHigherScore(ManageScene.Instance.higherScore);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetHigherScore(int highScore)
    {
        score = highScore;
        HigherScoreText.text = $"Highest Score: {score}";
    }

    public void GetButtonValue()
    {
        ManageScene.Instance.inputText = nameInput.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);

    }


    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }


}
