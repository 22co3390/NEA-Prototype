using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FebAssess
{
    public class WorldwideRecipes
    {
        public bool success { get; set; }
        public string message { get; set; }
        public result results { get; set; }
    }

    public class result
    {
        public string[] ingredients { get; set; }
        public string[] searches { get; set; }
        public seo seo { get; set; }
        public feed[] feed { get; set; }
        public relatePhrases relatedPhrases { get; set; }
        public int adTrackingCampaign { get; set; }
        public criteria criteria { get; set; }
        public int totalMatchCount { get; set; }
        public bool noindex { get; set; }

    }
    public class criteria
    {
        public string q { get; set; }   
        public int start { get; set; }
    }
    public class relatePhrases
    {
        public string[] relatedPhrases { get; set; }
        public string[] unrelatedPhrases { get; set; }
        public string[] keywords { get; set; }
        public string[] recipes { get; set; }
        public string phrase { get; set; }
    }
    public class feed
    {
        public seo1 seo { get; set; }
        public string tracking_id { get; set; }
        public string locale { get; set; }
        public content content { get; set; }
        public string type { get; set; }
        public string[] recipeType { get; set; }
        public bool proRecipe { get; set; }
        public display display { get; set; }
        public bool promoted { get; set; }
        public searchResult searchResult { get; set; }
    }
    public class description
    {
        public string mobileSectionName { get; set; }
        public string name { get; set; }
    }
    public class content
    {
        public description description { get; set; }
        public morecont moreContent { get; set; }
        public details details { get; set; }
        public morecont1 relatedContent { get; set; }
        public ingredientLines[] ingredientLines { get; set; }
        public string unitSystem { get; set; }
        public review reviews { get; set; }
        public queryparams relatedProducts { get; set; }
        public int preperationStepCount { get; set; }
        public morecont nutrtion { get; set; }
        public yums yums { get; set; }

    }
    public class searchResult
    {
        public double? score { get; set; }
    }
    public class display
    {
        public string displayName { get; set; }
        public string[] images { get; set; }
        public source source { get; set; }
        public profiles[] profiles { get; set; }


    }
    public class profiles
    {
        public string profileName { get; set; }
        public string displayName { set; get; }
        public string siteUrl { get; set; }
        public string pictureUrl { get; set; }
        public string pageUrl { get; set; }
        public string description { get; set; }
        public string type { set; get; }
        public string profileUrl { get; set; }

    }
    public class source
    {
        public string sourceRecipeUrl { get; set; }
        public string sourceFaviconUrl { get; set; }
        public string sourceHttpsOk { get; set; }
        public string sourceInFrame { get; set; }
        public string sourceDisplayName { get; set; }
        public string sourceSiteUrl { get; set; }
        public string sourcePageUrl { get; set; }
        public string sourceHttpOk { get; set; }

    }
    public class yums
    {
        public int count { get; set; }
        public string this_user { get; set; }


    }
    public class review
    {
        public string mobilesectionName { get; set; }
        public int totalReviewCount { get; set; }
        public double? averageRating { get; set; }
        public string sortBy { get; set; }
    }
    public class ingredientLines
    {
        public string category { get; set; }
        public amount amount { get; set; }
        public string unit { get; set; }
        public string ingredientId { get; set; }
        public string categoryId { get; set; }
        public relatedrecipesearchterm[] relatedRecipeSearchTerm { get; set; }
        public string ingredient { get; set; }
        public string id { get; set; }
        public string remainder { get; set; }
        public double? quantity { get; set; }
        public string wholeLine { get; set; }

    }
    public class relatedrecipesearchterm
    {
        public string allowedIngredient { get; set; }
    }
    public class amount
    {
        public metric metric { get; set; }
        public imperial imperial { get; set; }

    }
    public class imperial
    {
        public unit unit { get; set; }
        public double? quantity { get; set; }
    }

    public class metric
    {
        public unit unit { get; set; }
        public double? quantity { get; set; }
    }
    public class unit
    {
        public string id { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        public string plural { get; set; }
        public string pluralAbbreviation { get; set; }
        public string kind { get; set; }
        public bool decimal_ { get; set; }

    }
    public class morecont1
    {
        public string mobileSectionName { get; set; }
        public queryparams queryparams { get; set; }
    }
    public class queryparams
    {
        public int start { get; set; }
        public string apiFeedType { get; set; }
        public string id { get; set; }
    }
    public class details
    {
        public string directionsUrl { get; set; }
        public string totalTime { get; set; }
        public string displayName { get; set; }
        public images[] images { get; set; }
        public string name { get; set; }
        public string[] keywords { get; set; }
        public string id { get; set; }
        public attribution attribution { get; set; }
        public string recipeId { get; set; }
        public int numberOfServing { get; set; }
        public string globalId { get; set; }
        public int totalimeInSeconds { get; set; }
        public int rating { get; set; }


    }
    public class attribution
    {
        public string html { get; set; }
        public string url { get; set; }
        public string text { get; set; }
        public string logo { get; set; }
    }
    public class images
    {
        public string hostedLargeUrl { get; set; }
        public string resizableImageUrl { get; set; }
        public int resizableImageHeight { get; set; }
        public int resizableImageWidth { get; set; }
    }
    public class morecont
    {
        public string mobileSectonName { get; set; } 
    }
    public class seo1
    {
        public web1 web { get; set; }
        public spotlight spotlightSearch { get; set; }
        public fire1 firebase { get; set; }

    }
    public class fire1
    {
        public bool noindex { get; set; }
    }
    public class spotlight
    {
        public string[] keywords { get; set; }
        public bool noindex { get; set; }
    }
    public class web1
    {
        public bool noindex { get; set; }
        public string cannonical_term { get; set; }
        public metatags meta_tags { get; set; }
        public linktags[] link_tags { get; set; }
        public string image_url { get; set; }
    }
    public class seo
    {
        public web web { get; set; }
        public firebase firebase { get; set; }

    }
    public class firebase
    {
        public string webUrl { get; set; }
        public string appUrl { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
    public class web
    {
        public bool noindex { get; set; }
        public string display_title { get; set; }
        public string cannonical_term { get; set; }
        public metatags meta_tags { get; set; }
        public linktags[] link_tags { get; set; }
        public string image_url { get; set; }

    }
    public class linktags
    {
        public string rel { get; set; }
        public string hreflang { get; set; }
        public string href { get; set; }
    }
    public class metatags
    {
        public string title { get; set; }
        public string description { get; set; }
    }
}
