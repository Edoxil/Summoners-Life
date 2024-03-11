using UnityEngine;
using System;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using System.Collections;

namespace SummonersLife
{
    public class AppStartup : MonoBehaviour
    {
        [SerializeField] private int _loadingSceneIndex =1;

        private IEnumerator  Start()
        {
            yield return new WaitForSeconds(1);

            SceneManager.LoadScene(_loadingSceneIndex);
        }
    }
}
