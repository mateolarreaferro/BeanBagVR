using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{

    public static ScoreController Instance;
    public int currentScore;

    public TextMeshProUGUI scoreText;

    public CanvasGroup winScreen, loseScreen;

    public GameObject board;

    float offset = 1f;

    bool ReadyFreddy, RotationStatus;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        ChangeText();
        winScreen.alpha = 0;
        loseScreen.alpha = 0;
        ReadyFreddy = true;
        RotationStatus = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(RotationStatus == true)
        {
            RotateBoard();
        }


        if(currentScore == 1 && ReadyFreddy == true)
        {
            MoveBoard();
            ReadyFreddy = false;
        }

        if (currentScore == 2 && ReadyFreddy == false)
        {
            MoveBoard();
            RotationStatus = true;
            ReadyFreddy = true;
        }

        if (currentScore == 3 && ReadyFreddy == true)
        {
            MoveBoard();
            RotationStatus = false;
            ReadyFreddy = false;
        }

        if (currentScore == 4 && ReadyFreddy == false)
        {
            MoveBoard();
            ReadyFreddy = true;
        }

        if (currentScore == 5 && ReadyFreddy == true)
        {
            MoveBoard();
            ReadyFreddy = false;
        }

        if (currentScore == 6)
        {
            WinGame();
        }
    }

    public void HitHole()
    {
        currentScore += 1;
        ChangeText();
    }
    void ChangeText()
    {
        scoreText.text = currentScore.ToString();
    }
    public void WinGame()
    {
        winScreen.alpha = 1;
        Debug.Log("Congratulatons!");
        loseScreen.alpha = 0;
    }
    public void LoseGame()
    {
        loseScreen.alpha = 1;
        Debug.Log("Vergaos!");
        winScreen.alpha = 0;
    }
    void MoveBoard()
    {

        board.transform.position = new Vector3(board.transform.position.x, board.transform.position.y, board.transform.position.z + offset);
       
    }
    void RotateBoard()
    {
        //REVIEW WITH GREG
        //board.transform.Rotate(0f, 90f, 0f * Time.deltaTime * 0.001f);
    }

}
