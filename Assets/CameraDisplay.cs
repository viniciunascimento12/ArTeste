using UnityEngine;
using UnityEngine.UI;

public enum Scenario {
    Mockup3D,
    Video
}

public class CameraDisplay : MonoBehaviour {

    public static Scenario scenario;
    public Image[] image;
    // Start is called before the first frame update
    void Awake () {
        Screen.orientation = ScreenOrientation.Landscape;
        SetImage ();
        WebCamTexture webCamTexture = new WebCamTexture ();
        this.GetComponent<MeshRenderer> ().material.mainTexture = webCamTexture;
        webCamTexture.Play ();
    }

    public void SetImage () {
        switch (scenario) {
            case Scenario.Mockup3D:
                image[1].gameObject.SetActive (false);
                break;
            case Scenario.Video:
                image[0].gameObject.SetActive (false);
                break;
        }
    }

}