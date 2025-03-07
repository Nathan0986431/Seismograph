using UnityEngine;
using TMPro;

public class GameBehavior : MonoBehaviour
{
    public static GameBehavior Instance;

    
    public Utilities.GameplayState State;
    // [SerializeField] private TextMeshProUGUI _pauseMessage;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    void Start()
    {
        
        State = Utilities.GameplayState.Play;
        // _pauseMessage.enabled = false;
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            State = State == Utilities.GameplayState.Play
                ? Utilities.GameplayState.Pause
                : Utilities.GameplayState.Play;

            // _pauseMessage.enabled = !_pauseMessage.enabled;
        }
    }
}
