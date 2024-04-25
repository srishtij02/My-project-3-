using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Brick_Breaker_2._Scripts
{public class GameReseter : MonoBehaviour
    {
        public void OnCollisionEnter2D(Collision2D Other)
        {
            if (!Other.gameObject.CompareTag("Ball")) return;
            SceneManager.LoadScene("MainGame");
        }
        
            
        }
 
}
