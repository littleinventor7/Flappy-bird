using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicMScript : MonoBehaviour
{
  public int ps = 0;
  public Text scoretext;
  public GameObject gameoverscreen;
  [ContextMenu("Increas Score")]
  public void addScore(int scorettoadd){
    ps += scorettoadd;
    scoretext.text = ps.ToString();
  }
  public void restartGame(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
  public void gameover(){
      gameoverscreen.SetActive(true);
  }
}
