using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIMenu : MonoBehaviour
{
    [SerializeField]
    Slider volumeSilder;
    private void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume",1);
            Load();
        }
        else
        {
            Load();
        }

    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSilder.value;
        Save();
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSilder.value);
    }
    public void Load()
    {
        volumeSilder.value = PlayerPrefs.GetFloat("musicVolume");
    }
}
