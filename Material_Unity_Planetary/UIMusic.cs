using UnityEngine;


public class UIMusic : MonoBehaviour
{
    public MusicManager m_music_manager;
    private bool mainTitle;

    private string title1 = "MainMenuAudio";
    private string title2 = "PlanetaryAudio";    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainTitle = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchMusic()
    {
        m_music_manager.StopAll();
        if (mainTitle)
        {
            m_music_manager.PlayMusic(title2);
            mainTitle = false;
        }
        else
        {
            m_music_manager.PlayMusic(title1);
        }
    }
}
