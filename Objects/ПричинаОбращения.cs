﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Горводоканал
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Причина обращения.
    /// </summary>
    // *** Start programmer edit section *** (ПричинаОбращения CustomAttributes)

    // *** End programmer edit section *** (ПричинаОбращения CustomAttributes)
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored(false)]
    [Caption("Причина обращения")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПричинаОбращенияE", new string[] {
            "Название as \'Название\'",
            "Код as \'Код\'",
            "Актуально as \'Актуально\'"})]
    [View("ПричинаОбращенияL", new string[] {
            "Название as \'Название\'",
            "Код as \'Код\'",
            "Актуально as \'Актуально\'"})]
    public class ПричинаОбращения : IIS.Горводоканал.Справочник
    {
        
        private string fНазвание;
        
        private int fКод;
        
        // *** Start programmer edit section *** (ПричинаОбращения CustomMembers)

        // *** End programmer edit section *** (ПричинаОбращения CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (ПричинаОбращения.Название CustomAttributes)

        // *** End programmer edit section *** (ПричинаОбращения.Название CustomAttributes)
        [StrLen(150)]
        [NotNull()]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (ПричинаОбращения.Название Get start)

                // *** End programmer edit section *** (ПричинаОбращения.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (ПричинаОбращения.Название Get end)

                // *** End programmer edit section *** (ПричинаОбращения.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПричинаОбращения.Название Set start)

                // *** End programmer edit section *** (ПричинаОбращения.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (ПричинаОбращения.Название Set end)

                // *** End programmer edit section *** (ПричинаОбращения.Название Set end)
            }
        }
        
        /// <summary>
        /// Код.
        /// </summary>
        // *** Start programmer edit section *** (ПричинаОбращения.Код CustomAttributes)

        // *** End programmer edit section *** (ПричинаОбращения.Код CustomAttributes)
        public virtual int Код
        {
            get
            {
                // *** Start programmer edit section *** (ПричинаОбращения.Код Get start)

                // *** End programmer edit section *** (ПричинаОбращения.Код Get start)
                int result = this.fКод;
                // *** Start programmer edit section *** (ПричинаОбращения.Код Get end)

                // *** End programmer edit section *** (ПричинаОбращения.Код Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПричинаОбращения.Код Set start)

                // *** End programmer edit section *** (ПричинаОбращения.Код Set start)
                this.fКод = value;
                // *** Start programmer edit section *** (ПричинаОбращения.Код Set end)

                // *** End programmer edit section *** (ПричинаОбращения.Код Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПричинаОбращенияE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПричинаОбращенияE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПричинаОбращенияE", typeof(IIS.Горводоканал.ПричинаОбращения));
                }
            }
            
            /// <summary>
            /// "ПричинаОбращенияL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПричинаОбращенияL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПричинаОбращенияL", typeof(IIS.Горводоканал.ПричинаОбращения));
                }
            }
        }
    }
}
