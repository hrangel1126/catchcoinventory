namespace Inventory.Client.Modelos
{
//To nicely process the apiu repsonse, I could process it raw but better a model
    public class ApiResponse
{
    public string? status { get; set; }
    public int? count { get; set; }
    public List<ProductResponse>? data { get; set; }
    public bool? slackMessageSent { get; set; }
    public string? slackMessSent { get; set; }
    public string? slackDownloadUrl { get; set; }
    public SlackOutMessage? slackOutMessage { get; set; }
}
   public class ProductResponse
{
  public long? id { get; set; }
    public string? title { get; set; }
    public string? product_type { get; set; }
    public string? status { get; set; }
    public string? image { get; set; }
    public int? committed { get; set; }
    public int? available { get; set; }
    public int? onHand { get; set; }
    public int? stock_risk { get; set; }
    public bool? triggerAlert { get; set; }
    // Main SKU when variant title = product title
    public string? Sku { get; set; }

    // Only real variants go here
        public List<VarianttoDisplay>? variants { get; set; }
    // public List<VarianttoDisplay>? Variants { get; set; } = new();
}

    public class VarianttoDisplay {
 public long? id { get; set; }
    public string? product_title { get; set; }
    public long? product_id { get; set; }
    public bool? requires_shipping { get; set; }
    public string? sku { get; set; }
    public long? inventory_item_id { get; set; }
    public int? inventory_available { get; set; }
}

//incase we return slackmemssage
public class SlackOutMessage
{
    public bool? slack_simulation { get; set; }
    public string? channel { get; set; }
    public string? username { get; set; }
    public string? icon_emoji { get; set; }
    public string? text { get; set; }
    public List<SlackAttachment>? attachments { get; set; }
}
public class SlackAttachment
{
    public bool? slack_simulation { get; set; }
    public string? channel { get; set; }
    public string? username { get; set; }
    public string? icon_emoji { get; set; }
    public List<SlacoOuttxt>? attachments { get; set; }
}
public class SlacoOuttxt
{
    public string? fallback { get; set; }
    public string? color { get; set; }
    public string? title { get; set; }
    public string? text { get; set; }
    public string? thumb_url { get; set; }
    public List<SlackField>? fields { get; set; }
    public string? footer { get; set; }
    public long? ts { get; set; }
}
public class SlackField
{
    //@shot we added @ as ins a reseved word, i think
    public string? title { get; set; }
    public string? value { get; set; }
    public bool? @short { get; set; }
}
}
