using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.name == "GoLevel3")
            {
                Completlevel2();

            }
        }
        private void Completlevel2()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    
}
