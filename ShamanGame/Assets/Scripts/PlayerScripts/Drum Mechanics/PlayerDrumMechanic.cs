using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDrumMechanic : MonoBehaviour
{
    public bool drumIsPressed = false;
    public bool isPlayingDrums = false;
    public bool drumCounter = false;


    [SerializeField] private AudioSource drumSource;
    [SerializeField] private AudioClip drumClip;

    private float boolTimer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PlayDrums();        
    }

    public void OnPlayDrums(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            drumIsPressed = true;
            PlayDrums();
            PlayDrumSound();
        }
    }

    private bool PlayDrums()
    {
        if (drumIsPressed)
        {
            isPlayingDrums = true;
            Debug.Log("Drum played");
            drumIsPressed = false;
            drumCounter = true;

            return true;
        }
        else
        {
            isPlayingDrums = false;
            return false;
        }
    }

    private void PlayDrumSound()
    {
        if (drumSource != null)
        {
            drumSource.PlayOneShot(drumClip);
        }
    }

}
