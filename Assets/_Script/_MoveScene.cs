using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _MoveScene : MonoBehaviour {

    public void MoveScene(int TargetScene)
    {
        SceneManager.LoadScene(TargetScene);
    }

}
