using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character_button : MonoBehaviour
    
{
    public GameObject man, ice, sun, dust, virus, mushroom,temp_char,introduction;
    public GameObject black_man, black_ice, black_sun, black_dust, black_virus,black_mushroom;
    public GameObject man_image, ice_image, sun_image, dust_image, virus_image, mushroom_image;

    public void Start()
    {
        if (playerprefs_info.player.mushroom == 0)
        {
            mushroom_image.SetActive(false);
            black_mushroom.SetActive(true);
        }
        else 
        {
            mushroom_image.SetActive(true);
            black_mushroom.SetActive(false);
        }


        if (playerprefs_info.player.ice == 0)
        {
            ice_image.SetActive(false);
            black_ice.SetActive(true);
        }
        else
        {
            ice_image.SetActive(true);
            black_ice.SetActive(false);
        }


        if (playerprefs_info.player.sun == 0)
        {
            sun_image.SetActive(false);
            black_sun.SetActive(true);
        }
        else
        {
            sun_image.SetActive(true);
            black_sun.SetActive(false);
        }


        if (playerprefs_info.player.virus == 0)
        {
            virus_image.SetActive(false);
            black_virus.SetActive(true);
        }
        else
        {
            virus_image.SetActive(true);
            black_virus.SetActive(false);
        }


        if (playerprefs_info.player.dust == 0)
        {
            dust_image.SetActive(false);
            black_dust.SetActive(true);
        }
        else
        {
            dust_image.SetActive(true);
            black_dust.SetActive(false);
        }
    }
    public void choose_button()
    {
        choose_character(temp_char.name);
    }

    public void man_button()
    {
        introduction.SetActive(true);
        temp_char = man;
    }
    public void ice_button()
    {
        introduction.SetActive(true);
        temp_char = ice;
    }
    public void sun_button()
    {
        introduction.SetActive(true);
        temp_char = sun;
    }
    public void dust_button()
    {
        introduction.SetActive(true);
        temp_char = dust;
    }
    public void virus_button()
    {
        introduction.SetActive(true);
        temp_char = virus;
    }
    public void mushroom_button()
    {
        introduction.SetActive(true);
        temp_char = mushroom;
    }



    public void cancel_button()
    {
        introduction.SetActive(false);
    }
    public void choose_character(string name)
    {
        PlayerPrefs.SetString("character_name", name);
        playerprefs_info.player.character_name = PlayerPrefs.GetString("character_name");
        playerprefs_info.player.character = (GameObject)Resources.Load("prefab/character/" + playerprefs_info.player.character_name);
        introduction.SetActive(false);
    }
    public void return_button()
    {
        SceneManager.LoadScene("status_scene");
    }

}
