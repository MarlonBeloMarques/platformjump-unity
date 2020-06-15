using UnityEngine;

public class Controle_ResoluctionTela : MonoBehaviour {

    public RectTransform screen;
    public float y;
    private float reserv;
    public float screenwidht;
    public float screenheight;
    // Use this for initialization
    void Awake() {
        reserv = screen.sizeDelta.y;

        screenwidht = Screen.width;
        screenheight = Screen.height;

        screen.sizeDelta = new Vector2(screen.sizeDelta.x, reserv * (screenheight / screenwidht / y));
    }
}
