﻿
using System;
using System.ComponentModel.DataAnnotations;

namespace SyZero.Domain.Model
{
    public class Article: EntityRoot
    {
        //标题
        [MaxLength(200), Required] public string Title { get; set; }

        //类型
        public int Ctid { get; set; }

        //作者
        [MaxLength(200)] public string Author { get; set; }

        //图片
        [MaxLength(200)] public string Img { get; set; }

        //日期
        public System.DateTime AddTime { get; set; }

        //内容
        public string Content { get; set; }

        //热度
        public int Hot { get; set; }

        public int IsDisplay { get; set; }

        public int Status { get; set; }

        /// <summary>
        /// 文章构造函数
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="ctid">类型</param>
        /// <param name="author">作者</param>
        /// <param name="img">图片</param>
        /// <param name="context">内容</param>
        public Article(string title, int ctid, string author, string img, string context,int status)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("文章名称不能为空！");
            }
            if (string.IsNullOrEmpty(author))
            {
                throw new ArgumentException("作者不能为空！");
            }
            Title = title;
            Ctid = ctid;
            Author = author;
            Img = img;
            Content = context;
            AddTime = DateTime.Now;
            Hot = 0;
            Status = status;
        }

        public Article()
        {
           
        }

        /// <summary>
        /// 创建新文章
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="ctid">类型</param>
        /// <param name="author">作者</param>
        /// <param name="img">图片</param>
        /// <param name="context">内容</param>
        /// <returns></returns>
        public Article CreateArticle(string title, int ctid, string author, string img, string context,int status)
        {
            return new Article(title, ctid, author, img, context, status);
        }

        /// <summary>
        /// 修改Article
        /// </summary>
        /// <param name="title"></param>
        /// <param name="ctid"></param>
        /// <param name="author"></param>
        /// <param name="img"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public Article UpdateArticle(string title, int ctid, string author, string img, string context, int status)
        {
            this.Title = title;
            this.Ctid = ctid;
            this.Author = author;
            this.Img = img;
            this.Content = context;
            this.Status = status;
            return this;
        }


    }
}
