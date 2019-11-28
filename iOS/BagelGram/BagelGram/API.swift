//  This file was automatically generated and should not be edited.

import Apollo
import Foundation

public final class GetImagesQuery: GraphQLQuery {
  /// The raw GraphQL definition of this operation.
  public let operationDefinition =
    """
    query GetImages {
      getImages {
        __typename
        id
        source
        caption
        uploaded
        totalLikes
      }
    }
    """

  public let operationName = "GetImages"

  public init() {
  }

  public struct Data: GraphQLSelectionSet {
    public static let possibleTypes = ["Query"]

    public static let selections: [GraphQLSelection] = [
      GraphQLField("getImages", type: .list(.object(GetImage.selections))),
    ]

    public private(set) var resultMap: ResultMap

    public init(unsafeResultMap: ResultMap) {
      self.resultMap = unsafeResultMap
    }

    public init(getImages: [GetImage?]? = nil) {
      self.init(unsafeResultMap: ["__typename": "Query", "getImages": getImages.flatMap { (value: [GetImage?]) -> [ResultMap?] in value.map { (value: GetImage?) -> ResultMap? in value.flatMap { (value: GetImage) -> ResultMap in value.resultMap } } }])
    }

    /// All Images
    public var getImages: [GetImage?]? {
      get {
        return (resultMap["getImages"] as? [ResultMap?]).flatMap { (value: [ResultMap?]) -> [GetImage?] in value.map { (value: ResultMap?) -> GetImage? in value.flatMap { (value: ResultMap) -> GetImage in GetImage(unsafeResultMap: value) } } }
      }
      set {
        resultMap.updateValue(newValue.flatMap { (value: [GetImage?]) -> [ResultMap?] in value.map { (value: GetImage?) -> ResultMap? in value.flatMap { (value: GetImage) -> ResultMap in value.resultMap } } }, forKey: "getImages")
      }
    }

    public struct GetImage: GraphQLSelectionSet {
      public static let possibleTypes = ["Image"]

      public static let selections: [GraphQLSelection] = [
        GraphQLField("__typename", type: .nonNull(.scalar(String.self))),
        GraphQLField("id", type: .nonNull(.scalar(GraphQLID.self))),
        GraphQLField("source", type: .nonNull(.scalar(String.self))),
        GraphQLField("caption", type: .nonNull(.scalar(String.self))),
        GraphQLField("uploaded", type: .nonNull(.scalar(String.self))),
        GraphQLField("totalLikes", type: .nonNull(.scalar(Int.self))),
      ]

      public private(set) var resultMap: ResultMap

      public init(unsafeResultMap: ResultMap) {
        self.resultMap = unsafeResultMap
      }

      public init(id: GraphQLID, source: String, caption: String, uploaded: String, totalLikes: Int) {
        self.init(unsafeResultMap: ["__typename": "Image", "id": id, "source": source, "caption": caption, "uploaded": uploaded, "totalLikes": totalLikes])
      }

      public var __typename: String {
        get {
          return resultMap["__typename"]! as! String
        }
        set {
          resultMap.updateValue(newValue, forKey: "__typename")
        }
      }

      /// The Image ID
      public var id: GraphQLID {
        get {
          return resultMap["id"]! as! GraphQLID
        }
        set {
          resultMap.updateValue(newValue, forKey: "id")
        }
      }

      public var source: String {
        get {
          return resultMap["source"]! as! String
        }
        set {
          resultMap.updateValue(newValue, forKey: "source")
        }
      }

      /// The caption of the image
      public var caption: String {
        get {
          return resultMap["caption"]! as! String
        }
        set {
          resultMap.updateValue(newValue, forKey: "caption")
        }
      }

      /// The date the image was uploaded
      public var uploaded: String {
        get {
          return resultMap["uploaded"]! as! String
        }
        set {
          resultMap.updateValue(newValue, forKey: "uploaded")
        }
      }

      /// Number of likes an image has
      public var totalLikes: Int {
        get {
          return resultMap["totalLikes"]! as! Int
        }
        set {
          resultMap.updateValue(newValue, forKey: "totalLikes")
        }
      }
    }
  }
}
