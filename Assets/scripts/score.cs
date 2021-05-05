using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public float Score;
    public float Hscore;
    public int combo;
    public GameObject Scoreobj;
    public GameObject HSobj;
    public GameObject playerobj;
    public GameObject comboobj;
    const string scorekey = "Hscore";
    void Start()
    {
        Loadprefs();
    }

    void Update()
    {
        if(playerobj)
        {
            Score += Time.deltaTime * combo;
        }

        int scoreval = (int) Score;
        int Hscoreval = (int) Hscore;
        Scoreobj.GetComponent<TMPro.TextMeshProUGUI>().text = scoreval.ToString();
        HSobj.GetComponent<TMPro.TextMeshProUGUI>().text = Hscoreval.ToString();
        comboobj.GetComponent<TMPro.TextMeshProUGUI>().text = combo.ToString();

        if (Score > Hscore)
        {
            Hscore = Score;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Saveprefs();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if ((Input.GetKeyDown(KeyCode.A) | Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.D)) && playerobj.GetComponent<playermovement>().moveab == false)
        {
            combo = 1;
        }

        if ((Input.GetKeyDown(KeyCode.A) | Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.D)) && playerobj.GetComponent<playermovement>().moveab == true)
        {
            combo += 1;
        }
    }

    void OnApplicationQuit()
    {
        Saveprefs();
    }

    public void Loadprefs()
    {
        var savedscore = PlayerPrefs.GetFloat(scorekey, Hscore);
        Hscore = savedscore;

    }

    public void Saveprefs()
    {
        PlayerPrefs.SetFloat(scorekey, Hscore);
        PlayerPrefs.Save();
    }
}
