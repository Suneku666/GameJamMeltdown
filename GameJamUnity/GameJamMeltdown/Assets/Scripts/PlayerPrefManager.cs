using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";
    
    //level_unlocked_ + levelNumber

    public static void SetMasterVolume(float volume)
    {
        if (volume > 0f && volume < 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume out of range");
        }
    }

    public static float GetMastervolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void UnlockLevel(int level)
    {
        if(level <= Application.levelCount - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), level);
        }
        else
        {
            Debug.LogError("Trying to unlock level not in the build order");
        }
    }

    public static bool IsLevelUnlocked(int level)
    {
        if (level <= Application.levelCount - 1)
        {
            if (PlayerPrefs.GetInt(LEVEL_KEY + level.ToString()) == level)
            {
                return true;
            }
        }
        else
        {
            Debug.LogError("no such level exists in build order : " + level);
        }

        return false;
    }

    public static void SetDifficulty(float difficultyLevel)
    {
        if (0 <= difficultyLevel && difficultyLevel <= 1)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficultyLevel);
        }
        else
        {
            Debug.LogError("Saving Difficulty preference unsuccessfull with value : " + difficultyLevel);
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}
