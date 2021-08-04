using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDatabase : MonoBehaviour
{
    Hashtable playerData = new Hashtable();

    public InputField inputField;
    public Button searchButton;

    Player steve = new Player("Steve", "squiLLward", 3, 100);
    Player aaron = new Player("Aaron", "TheOriginal", 3, 100);
    Player chantelle = new Player("Chantelle", "SerasVictoriah", 3, 100);
    Player ciaran = new Player("Ciarán", "ciaranimo", 4, 9001);

    public Text nameText;
    public Text tagText;
    public Text levelText;
    public Text scoreText;

    private void Start()
    {
        playerData.Add("steve", steve);
        playerData.Add("aaron", aaron);
        playerData.Add("chantelle", chantelle);
        playerData.Add("ciaran", ciaran);

        searchButton.onClick.AddListener(() => searchPlayer(inputField));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            searchPlayer(inputField);
    }
    void searchPlayer(InputField search)
    {
        if (playerData.ContainsKey(search.text.ToLower()))
        {
            displayPlayer(playerData[search.text.ToLower()] as Player);
        }
        else
        {
            nameText.text = "TARGET";
            tagText.text = "PLAYER";
            levelText.text = "NOT";
            scoreText.text = "FOUND";
        }
    }

    void displayPlayer(Player player)
    {
        nameText.text = player.name;
        tagText.text = player.tag;
        levelText.text = player.level.ToString();

        if (player.score > 9000)
        {
            scoreText.text = "IT'S OVER 9000!";
        }
        else
        {
            scoreText.text = player.score.ToString();
        }
    }
}