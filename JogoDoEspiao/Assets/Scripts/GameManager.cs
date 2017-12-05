using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static List<string> locais;
    public string nomeJogador;

    public Button btnEntrar;
    public InputField txtNome;

    void TaskOnClick()
    {
        nomeJogador = txtNome.text;
        Debug.Log("You have clicked the button " + nomeJogador + ", Congrats!");
        SceneManager.LoadScene("PrimeiraCena");
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start ()
    {
        Button btn = btnEntrar.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        locais = new List<string>()
        {
            "Airplane",
            "Bank",
            "Beach",
            "Cathedral",
            "Circus Tent",
            "Corporate Party",
            "Crusader Army",
            "Casino",
            "Day Spa",
            "Embassy",
            "Hospital",
            "Hotel",
            "Military Base",
            "Movie Studio",
            "Ocean Liner",
            "Passenger Train",
            "Pirate Ship",
            "Polar Station",
            "Police Station",
            "Restaurant",
            "School",
            "Service Station",
            "Space Station",
            "Submarine",
            "Supermarket",
            "Theater",
            "University",
            "World War II Squad"
        };
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
