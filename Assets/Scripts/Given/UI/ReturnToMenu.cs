using Given.Manager;
using UnityEngine;
using UnityEngine.UI;

namespace Given.UI
{
    [RequireComponent(typeof(Button))]
    public class ReturnToMenu : MonoBehaviour
    {
        [SerializeField] private int levelID;

        private void Awake()
        {
            GetComponent<Button>().onClick.AddListener(ReturnToMenuImplementation);
        }

        private void ReturnToMenuImplementation()
        {
            LoadingManager.Instance.LoadLevelById(levelID);
        }
    }  
}
