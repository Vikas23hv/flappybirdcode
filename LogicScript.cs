using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
  public int playerScore;
  public Text score;
  public GameObject gameOverScreen;
  [ContextMenu("Increase Score")]
  public void add(int scoreToAdd){
    playerScore = playerScore + scoreToAdd;
    score.text = playerScore.ToString();
  }
  public void restart(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
  public void gameOver(){
    gameOverScreen.SetActive(true);
  }
}
