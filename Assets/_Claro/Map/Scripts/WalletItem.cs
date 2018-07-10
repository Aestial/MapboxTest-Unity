using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Claro
{
    public class WalletItem : MonoBehaviour
    {

        void Start()
        {

        }

        public void OnSharePressed()
        {
            ShareModalController.Instance.EnableModal(true);
        }
    }
}
