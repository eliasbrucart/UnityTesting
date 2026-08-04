using UnityEngine;
using UnityEngine.Video;

public class LoadVideo : MonoBehaviour{
    public VideoPlayer player;

    //public VideoSource source { get; private set; }

    void Start(){
        player.source = VideoSource.Url;
        player.url = "https://fv.hardgames.com.ar/views/img/Leiva/fullDayFile/Leiva_2024-09-29_1727638549_video.mp4";
        player.renderMode = VideoRenderMode.CameraFarPlane;
        player.Prepare();
        player.Play();
    }

    void Update() {
        
    }
}
