using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AudioController : MonoBehaviour
{
    public AudioController P_AudioController;
    public delegate void Shot();
    public AudioClip NewAudio;
    private AudioSource _background;
    [SerializeField] private GameObject _Player;
    // Start is called before the first frame update
    void Start()
    {
        _background = GetComponent<AudioSource>();
        _background.Play();
    }
    // Update is called once per frame
    void Update()
    {

    }
}