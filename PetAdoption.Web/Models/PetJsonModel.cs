using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdoption.Web.Models
{
    public class PetJsonModel
    {
        /// <summary>
        /// 動物編號
        /// </summary>
        public string animal_id { get; set; }
        /// <summary>
        /// 動物的 subid
        /// </summary>
        public string animal_subid { get; set; }

        /// <summary>
        /// 動物區域 pkid
        /// </summary>
        public int animal_area_pkid { get; set; }
        /// <summary>
        /// 動物收容所 pkid
        /// </summary>
        public int animal_shelter_pkid { get; set; }
        /// <summary>
        /// 動物所在地
        /// </summary>
        public string animal_place { get; set; }
        /// <summary>
        /// 動物類型(狗)
        /// </summary>
        public string animal_kind { get; set; }
        /// <summary>
        /// 動物性別(M)
        /// </summary>
        public string animal_sex { get; set; }
        /// <summary>
        /// 動物體型(SMALL)
        /// </summary>
        public string animal_bodytype { get; set; }
        /// <summary>
        /// 動物顏色(黑色)
        /// </summary>
        public string animal_colour { get; set; }
        /// <summary>
        /// 動物年齡(CHILD)
        /// </summary>
        public string animal_age { get; set; }
        /// <summary>
        /// 消毒(T)
        /// </summary>
        public string animal_sterilization { get; set; }
        /// <summary>
        /// 疫苗(N)
        /// </summary>
        public string animal_bacterin { get; set; }
        /// <summary>
        /// 發現地點
        /// </summary>
        public string animal_foundplace { get; set; }
        /// <summary>
        /// 標題 title
        /// </summary>
        public string animal_title { get; set; }
        /// <summary>
        /// 動物狀態(OPEN)
        /// </summary>
        public string animal_status { get; set; }
        /// <summary>
        /// 評論
        /// </summary>
        public string animal_remark { get; set; }
        /// <summary>
        /// 標題 caption
        /// </summary>
        public string animal_caption { get; set; }
        /// <summary>
        /// 開啟日期
        /// </summary>
        public string animal_opendate { get; set; }
        /// <summary>
        /// 關閉日期
        /// </summary>
        public string animal_closeddate { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public string animal_update { get; set; }
        /// <summary>
        /// 創建日期
        /// </summary>
        public string animal_createtime { get; set; }
        /// <summary>
        /// 收容所名稱
        /// </summary>
        public string shelter_name { get; set; }
        /// <summary>
        /// 相簿名稱
        /// </summary>
        public object album_name { get; set; }
        /// <summary>
        /// 相簿檔案
        /// </summary>
        public string album_file { get; set; }
        /// <summary>
        /// 相簿 Base64 照片
        /// </summary>
        public object album_base64 { get; set; }
        /// <summary>
        /// 相簿更新
        /// </summary>
        public object album_update { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime cDate { get; set; }
        /// <summary>
        /// 收容所地址
        /// </summary>
        public string shelter_address { get; set; }
        /// <summary>
        /// 收容所電話
        /// </summary>
        public string shelter_tel { get; set; }
    }
}