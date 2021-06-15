using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    //�x�s�I�����֪�AudioSource Component
    private AudioSource bgMusicAudioSource;

    void OnEnable()
    {
        //�b�Ҧ�Game Object����MBackground Music
        bgMusicAudioSource = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>();
        //�Ȱ�����
        bgMusicAudioSource.Pause();
    }

    void OnDisable()
    {
        //�~�򭵼�
        bgMusicAudioSource.UnPause();
    }
}
