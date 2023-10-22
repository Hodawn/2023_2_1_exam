using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 다시 시작할 씬의 이름 (씬 이름은 프로젝트에 따라 다를 수 있습니다)
    public string restartSceneName = "PlayScene";

    public void RestartGame()
    {
        // 게임 오브젝트 초기화 및 다시 시작할 씬으로 이동
        // 여기에 초기화 및 리셋 코드 추가
        SceneManager.LoadScene(restartSceneName);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
