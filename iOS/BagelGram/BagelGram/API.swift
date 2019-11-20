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
        GraphQLField("id", type: .scalar(GraphQLID.self)),
        GraphQLField("source", type: .nonNull(.scalar(String.self))),
      ]

      public private(set) var resultMap: ResultMap

      public init(unsafeResultMap: ResultMap) {
        self.resultMap = unsafeResultMap
      }

      public init(id: GraphQLID? = nil, source: String) {
        self.init(unsafeResultMap: ["__typename": "Image", "id": id, "source": source])
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
      public var id: GraphQLID? {
        get {
          return resultMap["id"] as? GraphQLID
        }
        set {
          resultMap.updateValue(newValue, forKey: "id")
        }
      }

      /// The source url of the image
      public var source: String {
        get {
          return resultMap["source"]! as! String
        }
        set {
          resultMap.updateValue(newValue, forKey: "source")
        }
      }
    }
  }
}
