using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
namespace AG3959
{
    public class Pausemenu : MonoBehaviour
    {
        public static bool gameIsPaused = false;

        public GameObject pauseMenuUi;


        private void Start()
        {
            Cursor.visible = false;
        }
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.M))
            {
                if (gameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }

            if(Input.GetKeyUp(KeyCode.Mouse0))
            {
                Cursor.visible = true;
            }

            if (Input.GetKeyUp(KeyCode.Mouse2))
            {
                Cursor.visible = false;
            }
        }

        void Resume()
        {
            pauseMenuUi.SetActive(false);
            // Time.timeScale = 1;
            gameIsPaused = false;

        }

        void Pause()
        {
            pauseMenuUi.SetActive(true);
            // Time.timeScale = 0;
            gameIsPaused = true;
        }
    }
}