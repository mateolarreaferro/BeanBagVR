using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    //VARIABLES 

    public static ScoreController Instance; //Singleton

    public int currentScore; 

    public TextMeshProUGUI scoreText; //Reference to UI Text

    public CanvasGroup winScreen, loseScreen; //Canvas that will be displayed

    public GameObject board; //Reference to object

    float offset = 1f;

    bool ReadyFreddy;


    private void Awake() //Singleton
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
        ReadyFreddy = true; //Avoids that conditional gets called more than once
        
    }

    // Update is called once per frame
    void Update()
    {
        //Game's Progression

        if(currentScore == 1 && ReadyFreddy == true)
        {
            MoveBoard();
            ReadyFreddy = false;
        }

        if (currentScore == 2 && ReadyFreddy == false)
        {
            MoveBoard();
            ReadyFreddy = true;
        }

        if (currentScore == 3 && ReadyFreddy == true)
        {
            MoveBoard();
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

    public void HitHole() //Increase Score
    {
        currentScore += 1;
        ChangeText();
    }

    void ChangeText() //Update Text to Score
    {
        scoreText.text = currentScore.ToString();
    }

    public void WinGame() //UI
    {
        winScreen.alpha = 1;
        Debug.Log("Congratulatons!");
        loseScreen.alpha = 0;
    }

    public void LoseGame() //UI -> Currently not happening 
    {
        loseScreen.alpha = 1;
        Debug.Log("Vergaos!");
        winScreen.alpha = 0;
    }

    void MoveBoard() //Distance to Board Increases
    {

        board.transform.position = new Vector3(board.transform.position.x, board.transform.position.y, board.transform.position.z + offset);
       
    }
   

}
