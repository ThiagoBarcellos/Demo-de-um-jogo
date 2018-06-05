using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TypeWrite : MonoBehaviour {

    //Maquina de Escrever
    public string fullText;
    private string currentText = "";


    // Use this for initialization
    void Start()
    {
        StartCoroutine(ShowText());

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);

        }
    }

    IEnumerator ShowText()
    {
       
        for (int i = 0; i < fullText.Length; i++)
        {
                currentText = fullText.Substring(0, i);
                this.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(Random.Range(0.05f, 0.09f));
       
        }

    } 
}